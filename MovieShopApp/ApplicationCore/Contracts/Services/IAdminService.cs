using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Contracts.Services
{
	public interface IAdminService
	{
        int AddAdmin(User user);
        int UpdateAdmin(User user, int id);
        int DeleteAdmin(int id);
        IEnumerable<User> GetAllAdmins();
        User GetAdminById(int id);
    }
}
