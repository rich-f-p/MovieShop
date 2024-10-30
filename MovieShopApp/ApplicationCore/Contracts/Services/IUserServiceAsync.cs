using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Contracts.Services
{
	public interface IUserServiceAsync
	{
        Task<int> AddUserAsync(User user);
        Task<int> UpdateUserAsync(User user, int id);
        Task<int> DeleteUserAsync(int id);
        Task<IEnumerable<User>> GetAllUsersAsync();
        Task<User> GetUserByIdAsync(int id);
    }
}
