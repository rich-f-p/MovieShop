using ApplicationCore.Contracts.Repository;
using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;
using ApplicationCore.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infastructure.Services
{
    public class AccountServiceAsync : IAccountServiceAsync
    {
        private readonly IUserRepositoryAsync _repo;
        public AccountServiceAsync(IUserRepositoryAsync repo)
        {
            _repo = repo;
        }
        public async Task<int> AddAccountAsync(RegisterModel model)
        {
            var result = new User
            {
                FirstName= model.FirstName,
                LastName= model.LastName,
                DateOfBirth = model.DateOfBirth,
                Email = model.Email,
                HashedPassword = model.HashedPassword,
            };
            if(model.ConfirmPassword == result.HashedPassword)
            {
                return await _repo.InsertAsync(result);
            }
            return -1;
        }

        public async Task<int> DeleteAccountAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<User> GetAccountByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<User>> GetAllAccountsAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<int> UpdateAccountAsync(User user, int id)
        {
            throw new NotImplementedException();
        }
    }
}
