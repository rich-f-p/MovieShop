using ApplicationCore.Contracts.Repository;
using ApplicationCore.Entities;
using Infastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Infastructure.Repository
{
	public class CastRepositoryAsync : BaseRepositoryAsync<Cast>, ICastRepositoryAsync
	{
		private readonly MovieShopDbContext _context;
		public CastRepositoryAsync(MovieShopDbContext c) : base(c)
		{
			_context = c;
		}
		public override async Task<Cast> GetByIdAsync(int id)
		{
			return await _context.Casts
				.Include(c => c.MovieCasts)
				.ThenInclude(mc => mc.Movies)
				.FirstOrDefaultAsync(c=>c.Id==id);
		}
	}
}
