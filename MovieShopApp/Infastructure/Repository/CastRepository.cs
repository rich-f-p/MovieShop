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
	public class CastRepository : BaseRepository<Cast>, ICastRepository
	{
		private readonly MovieShopDbContext _context;
		public CastRepository(MovieShopDbContext c) : base(c)
		{
			_context = c;
		}
		public override Cast GetById(int id)
		{
			return _context.Casts
				.Include(c => c.MovieCasts)
				.ThenInclude(mc => mc.Movies)
				.FirstOrDefault(c=>c.Id==id);
		}
	}
}
