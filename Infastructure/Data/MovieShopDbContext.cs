using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Infastructure.Data
{
	public class MovieShopDbContext : DbContext
	{
        public MovieShopDbContext(DbContextOptions<MovieShopDbContext> options) : base(options) 
		{
			
		}
        public DbSet<Cast> Casts { get; set; }
		public DbSet<Favorite> Favorites { get; set; }
		public DbSet<Genre> Genres { get; set; }
		public DbSet<MovieCast> MovieCasts { get; set; }
		public DbSet<MovieGenre> MovieGenres { get; set; }
		public DbSet<Movie> Movies { get; set; }
		public DbSet<Review> Reviews { get; set; }
		public DbSet<Role> Roles { get; set; }
		public DbSet<UserRole> UserRoles { get; set; }
		public DbSet<Trailer> Trailers { get; set; }
		public DbSet<User> Users { get; set; }
		public DbSet<Purchase> Purchases { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Movie>()
				.Property(b => b.UpdatedDate)
				.HasDefaultValueSql("getdate()");
			modelBuilder.Entity<Movie>()
				.Property(b => b.Price)
				.HasDefaultValue(Convert.ToDecimal(5));
			modelBuilder.Entity<Movie>()
				.Property(b => b.UpdatedBy)
				.HasDefaultValue("DataAdmin");
			modelBuilder.Entity<Movie>()
				.Property(b => b.CreatedDate)
				.HasDefaultValueSql("getdate()");
			modelBuilder.Entity<Movie>()
				.Property(b => b.CreatedBy)
				.HasDefaultValue("DataAdmin");
			modelBuilder.Entity<User>()
				.Property(u => u.Salt)
				.HasDefaultValue("salt");
			modelBuilder.Entity<User>()
				.Property(u => u.IsLocked)
				.HasDefaultValue(0);
		}
	}
}
