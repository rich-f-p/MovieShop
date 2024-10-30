using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Contracts.Services
{
	public interface IAdminServiceAsync
	{
        Task<int> AddAdminAsync(User user);
        Task<int> UpdateAdminAsync(User user, int id);
        Task<int> DeleteAdminAsync(int id);
        Task<IEnumerable<User>> GetAllAdminsAsync();
        Task<User> GetAdminByIdAsync(int id);
    }
}
