using ApplicationCore.Contracts.Repository;
using ApplicationCore.Entities;
using ApplicationCore.Models;
using Infastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infastructure.Repository
{
	public class MovieRepositoryAsync : BaseRepositoryAsync<Movie>, IMovieRepositoryAsync
	{
		private readonly MovieShopDbContext _context;
		public MovieRepositoryAsync(MovieShopDbContext c) : base(c)
		{
			_context = c;
		}
		public async Task<IEnumerable<Movie>> GetTopPurchasedMoviesAsync()
		{
			var result = await _context.Movies.Include(x => x.Purchases).ToListAsync();
			return result;
		}
		public async Task<IEnumerable<Movie>> GetHighestGrossingMoviesAsync()
		{
			var result = await _context.Movies.OrderByDescending(x=>x.Revenue).ToListAsync();
			return result;
		}
		public async Task<IEnumerable<Movie>> GetMoviesWithGenreAsync()
		{
			return await _context.Movies.Include(x=>x.MovieGenres).ToListAsync();
		}
		public async Task<Movie> GetMovieByIdAsync(int id)
		{
			var result = await _context.Movies
			.Include(m => m.MovieGenres).ThenInclude(mg => mg.Genre)
			.Include(m => m.Trailers)
			.Include(m => m.movieCasts).ThenInclude(mc=>mc.Casts)
			.FirstOrDefaultAsync(m => m.Id == id);
			return result;
		}

		public async Task<IEnumerable<Movie>> GetMovieByGenreAsync(int id)
		{
			var result = await _context.Movies.Where(m => m.MovieGenres.Any(g => g.GenreId == id))
                .ToListAsync();
			return result;
        }
	}
}
