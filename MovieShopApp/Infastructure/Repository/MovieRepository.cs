using ApplicationCore.Contracts.Repository;
using ApplicationCore.Entities;
using Infastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infastructure.Repository
{
	public class MovieRepository : BaseRepository<Movie>, IMovieRepository
	{
		private readonly MovieShopDbContext _context;
		public MovieRepository(MovieShopDbContext c) : base(c)
		{
			_context = c;
		}
		public IEnumerable<Movie> GetTopPurchasedMovies()
		{
			var result = _context.Movies.Include(x => x.Purchases).ToList();
			return result;
		}
		public IEnumerable<Movie> GetHighestGrossingMovies()
		{
			var result = _context.Movies.OrderByDescending(x=>x.Revenue).ToList();
			return result;
		}
		public IEnumerable<Movie> GetMoviesWithGenre()
		{
			return _context.Movies.Include(x=>x.MovieGenres).ToList();
		}
		public Movie GetMovieById(int id)
		{
			var result = _context.Movies
			.Include(m => m.MovieGenres).ThenInclude(mg => mg.Genre)
			.Include(m => m.Trailers)
			.Include(m => m.movieCasts).ThenInclude(mc=>mc.Casts)
			.FirstOrDefault(m => m.Id == id);
			return result;
		}
	}
}
