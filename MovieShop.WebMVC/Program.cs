using ApplicationCore.Contracts.Repository;
using ApplicationCore.Contracts.Services;
using Infastructure.Data;
using Infastructure.Repository;
using Infastructure.Services;
using Microsoft.Build.Execution;
using Microsoft.EntityFrameworkCore;
using MovieShop.WebMVC.Utility.CustomMiddleware;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

Log.Logger = new LoggerConfiguration().MinimumLevel.Debug().WriteTo.File("Log/Exception&Filter.json"
	,outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj}{NewLine}{Exception}"
	,shared:true,rollingInterval:RollingInterval.Day)
	.MinimumLevel.Information().WriteTo.File("Log/Exception&Filter.json"
	, outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj}{NewLine}{Exception}"
	, shared: true, rollingInterval: RollingInterval.Day).CreateLogger();
builder.Host.UseSerilog();

builder.Services.AddDbContext<MovieShopDbContext>(options =>
{
	options.UseSqlServer(builder.Configuration.GetConnectionString("MovieShopApp"));
});
builder.Services.AddScoped<IMovieRepositoryAsync, MovieRepositoryAsync>();
builder.Services.AddScoped<IMovieServiceAsync, MovieServiceAsync>();

builder.Services.AddScoped<IUserRepositoryAsync, UserRepositoryAsync>();
builder.Services.AddScoped<IUserServiceAsync, UserServiceAsync>();

builder.Services.AddScoped<ICastRepositoryAsync, CastRepositoryAsync>();
builder.Services.AddScoped<ICastServiceAsync, CastServiceAsync>();

builder.Services.AddScoped<IGenreRepositoryAsync, GenreRepositoryAsync>();
builder.Services.AddScoped<IGenreServiceAsync, GenreServiceAsync>();

builder.Services.AddScoped<IAdminServiceAsync, AdminServiceAsync>();
builder.Services.AddScoped<IAccountServiceAsync, AccountServiceAsync>();

builder.Services.AddScoped<IPurchaseRepositoryAsync,PurchaseRepositoryAsync>();

builder.Services.AddDistributedMemoryCache();

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromSeconds(10);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");//developer exceptionpage
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseSession();

app.UseExceptionMiddleware();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
