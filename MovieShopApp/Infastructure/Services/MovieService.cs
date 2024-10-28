using ApplicationCore.Contracts.Repository;
using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infastructure.Services
{
	public class MovieService : IMovieService
	{
		private readonly IMovieRepository _repo;
		public MovieService(IMovieRepository repo)
		{
			_repo = repo;
		}

		public int AddMovie(Movie movie)
		{
			return _repo.Insert(movie);
		}

		public int DeleteMovie(int id)
		{
			return _repo.Delete(id);
		}

		public IEnumerable<Movie> GetAllMovies()
		{
			var result = _repo.GetAll();
			return result;
		}

		public Movie GetMovieById(int id)
		{
			return _repo.GetById(id);
		}

		public int UpdateMovie(Movie movie, int id)
		{
			if(movie.Id == id)
			{
				return _repo.Update(movie);
			}
			return 0;
		}
	}
}
