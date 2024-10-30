using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infastructure.Services
{
    public class AdminServiceAsync : IAdminServiceAsync
    {
        public Task<int> AddAdminAsync(User user)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAdminAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetAdminByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetAllAdminsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAdminAsync(User user, int id)
        {
            throw new NotImplementedException();
        }
    }
}
