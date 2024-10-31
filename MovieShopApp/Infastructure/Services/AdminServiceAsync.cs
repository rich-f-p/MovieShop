using ApplicationCore.Contracts.Repository;
using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;
using ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infastructure.Services
{
    public class AdminServiceAsync : IAdminServiceAsync
    {
        private readonly IMovieRepositoryAsync _movieRepo;
        public AdminServiceAsync(IMovieRepositoryAsync m)
        {
            _movieRepo = m;
        }
        public Task<int> AddAdminAsync(User user)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAdminAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetAdminByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetAllAdminsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAdminAsync(User user, int id)
        {
            throw new NotImplementedException();
        }

        public async Task<int> CreateMovie(AddMovieModel movie)
        {
            var result = new Movie
            {
                BackdropUrl = movie.BackdropUrl,
                Budget = movie.Budget,
                CreatedDate = DateTime.Now,
                ImdbUrl = movie.ImdbUrl,
                OriginalLanguage = movie.OriginalLanguage,
                Overview = movie.Overview,
                PosterUrl = movie.PosterUrl,
                Price = movie.Price,
                ReleaseDate = movie.ReleaseDate,
                Revenue = movie.Revenue,
                RunTime = movie.RunTime,
                Tagline = movie.Tagline,
                Title = movie.Title,
                TmdbUrl = movie.TmdbUrl,
                UpdatedDate  = DateTime.Now
            };
            return await _movieRepo.InsertAsync(result);
        }

    }
}
