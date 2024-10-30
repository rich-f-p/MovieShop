using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Contracts.Services
{
	public interface IGenreServiceAsync
	{
        Task<int> AddGenreAsync(Genre genre);
        Task<int> UpdateGenreAsync(Genre genre, int id);
        Task<int> DeleteGenreAsync(int id);
        Task<IEnumerable<Genre>> GetAllGenresAsync();
        Task<Genre> GetGenreByIdAsync(int id);
    }
}
