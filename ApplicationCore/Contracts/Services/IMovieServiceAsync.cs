using ApplicationCore.Entities;
using ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Contracts.Services
{
	public interface IMovieServiceAsync
	{
		Task<int> AddMovieAsync(Movie movie);
		Task<int> UpdateMovieAsync(Movie movie,int id);
		Task<int> DeleteMovieAsync(int id);
		Task<IEnumerable<MovieCardModel>> GetAllMoviesAsync();
		Task<Movie> GetMovieByIdAsync(int id);
		Task<IEnumerable<Movie>> GetHighGrossingMoviesAsync();
		Task<PaginatedResultSet<MovieCardModel>> GetMoviesByGenreAsync(int id, int pageSize, int page);
		Task<Movie> GetMovieDetailsAsync(int id);
		Task<int> AddPurchaseAsync(Purchase purchase);

    }
}
