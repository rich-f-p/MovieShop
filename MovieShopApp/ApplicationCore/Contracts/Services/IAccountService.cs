using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Contracts.Services
{
	public interface IAccountService
	{
        int AddAccount(User user);
        int UpdateAccount(User user, int id);
        int DeleteAccount(int id);
        IEnumerable<User> GetAllAccounts();
        User GetAccountById(int id);
    }
}
