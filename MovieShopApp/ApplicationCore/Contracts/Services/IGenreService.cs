using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Contracts.Services
{
	public interface IGenreService
	{
        int AddGenre(Genre genre);
        int UpdateGenre(Genre genre, int id);
        int DeleteGenre(int id);
        IEnumerable<Genre> GetAllGenres();
        Genre GetGenreById(int id);
    }
}
