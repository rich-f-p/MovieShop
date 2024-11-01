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
    public class UserServiceAsync : IUserServiceAsync
    {
        private readonly IUserRepositoryAsync _repo;
        public UserServiceAsync(IUserRepositoryAsync repo)
        {
            _repo = repo;
        }
        public async Task<int> AddUserAsync(User user)
        {
            return await _repo.InsertAsync(user);
        }

        public async Task<int> DeleteUserAsync(int id)
        {
            return await _repo.DeleteAsync(id);
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            return await _repo.GetAllAsync();
        }

        public async Task<User> GetUserByIdAsync(int id)
        {
            return await _repo.GetByIdAsync(id);
        }

        public async Task<int> UpdateUserAsync(User user, int id)
        {
            if(user.Id == id)
            {
                return await _repo.UpdateAsync(user);
            }
            return 0;
        }
    }
}
