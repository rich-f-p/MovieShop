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
    public class CastServiceAsync : ICastServiceAsync
    {
        private readonly ICastRepositoryAsync _repo;
        public CastServiceAsync(ICastRepositoryAsync repo)
        {
            _repo = repo;
        }
        public async Task<int> AddCastAsync(Cast cast)
        {
            return await _repo.InsertAsync(cast);
        }

        public async Task<int> DeleteCastAsync(int id)
        {
            return await _repo.DeleteAsync(id);
        }

        public async Task<IEnumerable<Cast>> GetAllCastAsync()
        {
            var result = await _repo.GetAllAsync();
            return result;
        }

        public async Task<Cast> GetCastByIdAsync(int id)
        {
            return await _repo.GetByIdAsync(id);
        }

		public async Task<Cast> GetCastDetailsAsync(int id)
		{
			return await _repo.GetByIdAsync(id);
		}

		public async Task<int> UpdateCastAsync(Cast cast, int id)
        {
            if(cast.Id == id)
            {
                return await _repo.UpdateAsync(cast);
            }
            return 0;
        }
    }
}
