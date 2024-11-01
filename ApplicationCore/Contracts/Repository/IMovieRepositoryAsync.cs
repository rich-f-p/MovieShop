using ApplicationCore.Entities;
using ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Contracts.Repository
{
	public interface IMovieRepositoryAsync : IRepositoryAsync<Movie>
	{
		Task<IEnumerable<Movie>> GetHighestGrossingMoviesAsync();
		Task<IEnumerable<Movie>> GetMovieByGenreAsync(int id);
		Task<Movie> GetMovieByIdAsync(int id);

	}
}
