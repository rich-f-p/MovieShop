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
			return _context.Movies.Include(x => x.Purchases).ToList();
		}
	}
}
