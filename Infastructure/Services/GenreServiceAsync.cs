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
    public class GenreServiceAsync : IGenreServiceAsync
    {
        private readonly IGenreRepositoryAsync _repo;
        public GenreServiceAsync(IGenreRepositoryAsync repo)
        {
            _repo = repo;
        }
        public async Task<int> AddGenreAsync(Genre genre)
        {
            return await _repo.InsertAsync(genre);
        }

        public async Task<int> DeleteGenreAsync(int id)
        {
            return await _repo.DeleteAsync(id);
        }

        public async Task<IEnumerable<Genre>> GetAllGenresAsync()
        {
            var result = await _repo.GetAllAsync();
            return result;
        }

        public async Task<Genre> GetGenreByIdAsync(int id)
        {
            return await _repo.GetByIdAsync(id);
        }

        public async Task<int> UpdateGenreAsync(Genre genre, int id)
        {
            if(genre.Id == id)
            {
                return await _repo.UpdateAsync(genre);
            }
            return 0;
        }
    }
}
