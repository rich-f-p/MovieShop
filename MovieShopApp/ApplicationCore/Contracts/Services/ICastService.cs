using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Contracts.Services
{
	public interface ICastService
	{
        int AddCast(Cast cast);
        int UpdateCast(Cast cast, int id);
        int DeleteCast(int id);
        IEnumerable<Cast> GetAllCast();
        Cast GetCastById(int id);
        Cast GetCastDetails(int id);
    }
}
