using ApplicationCore.Contracts.Repository;
using ApplicationCore.Entities;
using Infastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infastructure.Repository
{
	public class UserRepository : BaseRepository<User>, IUserRepository
	{
		public UserRepository(MovieShopDbContext c) : base(c)
		{
		}
	}
}
