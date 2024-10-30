using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Contracts.Services
{
	public interface ICastServiceAsync
	{
        Task<int> AddCastAsync(Cast cast);
        Task<int> UpdateCastAsync(Cast cast, int id);
        Task<int> DeleteCastAsync(int id);
        Task<IEnumerable<Cast>> GetAllCastAsync();
        Task<Cast> GetCastByIdAsync(int id);
        Task<Cast> GetCastDetailsAsync(int id);
    }
}
