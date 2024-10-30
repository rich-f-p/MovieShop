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
    public class GenreRepositoryAsync : BaseRepositoryAsync<Genre>, IGenreRepositoryAsync
    {
		private readonly MovieShopDbContext _context;
		public GenreRepositoryAsync(MovieShopDbContext c) : base(c)
        {
            _context = c;
        }
    }
}
