using ApplicationCore.Contracts.Repository;
using ApplicationCore.Entities;
using Infastructure.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infastructure.Repository
{
	public class UserRepositoryAsync : BaseRepositoryAsync<User>, IUserRepositoryAsync
	{
		private readonly MovieShopDbContext _context;
		public UserRepositoryAsync(MovieShopDbContext c) : base(c)
		{
			_context = c;
		}

		public async Task<User> GetByEmailAsync(string email)
		{
			//grabs first case of the email
			//need to make sql column unique
			var result = await _context.Users.FirstOrDefaultAsync(x => x.Email == email);
			return result;
		}  
	}
}
