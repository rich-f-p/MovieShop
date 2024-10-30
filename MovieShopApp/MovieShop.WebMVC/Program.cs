using ApplicationCore.Contracts.Repository;
using ApplicationCore.Contracts.Services;
using Infastructure.Data;
using Infastructure.Repository;
using Infastructure.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

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

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
