using ApplicationCore.Contracts.Repository;
using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;
using ApplicationCore.Models;
using Azure;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infastructure.Services
{
	public class MovieServiceAsync : IMovieServiceAsync
	{
		private readonly IMovieRepositoryAsync _repo;
		private readonly IPurchaseRepositoryAsync _purchaseRepository;
		private readonly PurchaseDateValidation validator = new PurchaseDateValidation();
		public MovieServiceAsync(IMovieRepositoryAsync repo,IPurchaseRepositoryAsync purchase)
		{
			_repo = repo;
			_purchaseRepository = purchase;
		}

		public async Task<int> AddMovieAsync(Movie movie)
		{
			return await _repo.InsertAsync(movie);
		}

		public async Task<int> DeleteMovieAsync(int id)
		{
			return await _repo.DeleteAsync(id);
		}

		public async Task<IEnumerable<MovieCardModel>> GetAllMoviesAsync()
		{
			var result = await _repo.GetAllAsync();
			return result.Select(x => new MovieCardModel
            {
                Id = x.Id,
                Title = x.Title,
                PosterUrl = x.PosterUrl
            }).ToList();
            
        }

		public async Task<Movie> GetMovieByIdAsync(int id)
		{
			return await _repo.GetByIdAsync(id);
		}

		public async Task<int> UpdateMovieAsync(Movie movie, int id)
		{
			if(movie.Id == id)
			{
				return await _repo.UpdateAsync(movie);
			}
			return 0;
		}
		public async Task<IEnumerable<Movie>> GetHighGrossingMoviesAsync()
		{
			return await _repo.GetHighestGrossingMoviesAsync();
		}
		public async Task<Movie> GetMovieDetailsAsync(int id)
		{
			return await _repo.GetMovieByIdAsync(id);
		}

		public async Task<PaginatedResultSet<MovieCardModel>> GetMoviesByGenreAsync(int id, int pageSize,int page )
		{
            var movies = await _repo.GetMovieByGenreAsync(id);
			var count = movies.Count();
			var result = movies.Skip((page-1)*pageSize).Take(pageSize).Select(x=> new MovieCardModel
			{
				Id = x.Id,
				Title = x.Title,
				PosterUrl = x.PosterUrl
			}).ToList();
            return new PaginatedResultSet<MovieCardModel>(result,count,page,pageSize);
		}
        public async Task<int> AddPurchaseAsync(Purchase purchase)
        {
			ValidationResult result = validator.Validate(purchase);
			if (result.IsValid)
			{
                return await _purchaseRepository.InsertAsync(purchase);
			}
			else
			{
				Console.WriteLine(result.ToString("~"));
			}
			return 0;
        }
    }
}
