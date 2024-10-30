using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infastructure.Services
{
    public class AccountServiceAsync : IAccountServiceAsync
    {
        public async Task<int> AddAccountAsync(User user)
        {
            throw new NotImplementedException();
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
