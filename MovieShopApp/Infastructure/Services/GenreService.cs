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
    public class GenreService : IGenreService
    {
        private readonly IGenreRepository _repo;
        public GenreService(IGenreRepository repo)
        {
            _repo = repo;
        }
        public int AddGenre(Genre genre)
        {
            return _repo.Insert(genre);
        }

        public int DeleteGenre(int id)
        {
            return _repo.Delete(id);
        }

        public IEnumerable<Genre> GetAllGenres()
        {
            var result = _repo.GetAll();
            return result;
        }

        public Genre GetGenreById(int id)
        {
            return _repo.GetById(id);
        }

        public int UpdateGenre(Genre genre, int id)
        {
            if(genre.Id == id)
            {
                return _repo.Update(genre);
            }
            return 0;
        }
    }
}
