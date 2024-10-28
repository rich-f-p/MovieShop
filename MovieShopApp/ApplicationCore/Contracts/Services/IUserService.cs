using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Contracts.Services
{
	public interface IUserService
	{
        int AddUser(User user);
        int UpdateUser(User user, int id);
        int DeleteUser(int id);
        IEnumerable<User> GetAllUsers();
        User GetUserById(int id);
    }
}
