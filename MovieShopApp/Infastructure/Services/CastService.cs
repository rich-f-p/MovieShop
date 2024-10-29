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
    public class CastService : ICastService
    {
        private readonly ICastRepository _repo;
        public CastService(ICastRepository repo)
        {
            _repo = repo;
        }
        public int AddCast(Cast cast)
        {
            return _repo.Insert(cast);
        }

        public int DeleteCast(int id)
        {
            return _repo.Delete(id);
        }

        public IEnumerable<Cast> GetAllCast()
        {
            var result = _repo.GetAll();
            return result;
        }

        public Cast GetCastById(int id)
        {
            return _repo.GetById(id);
        }

		public Cast GetCastDetails(int id)
		{
			return _repo.GetById(id);
		}

		public int UpdateCast(Cast cast, int id)
        {
            if(cast.Id == id)
            {
                return _repo.Update(cast);
            }
            return 0;
        }
    }
}
