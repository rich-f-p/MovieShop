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
    public class UserService : IUserService
    {
        private readonly IUserRepository _repo;
        public UserService(IUserRepository repo)
        {
            _repo = repo;
        }
        public int AddUser(User user)
        {
            return _repo.Insert(user);
        }

        public int DeleteUser(int id)
        {
            return _repo.Delete(id);
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _repo.GetAll();
        }

        public User GetUserById(int id)
        {
            return _repo.GetById(id);
        }

        public int UpdateUser(User user, int id)
        {
            if(user.Id == id)
            {
                return _repo.Update(user);
            }
            return 0;
        }
    }
}
