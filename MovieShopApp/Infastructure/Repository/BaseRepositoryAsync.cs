using ApplicationCore.Contracts.Repository;
using Infastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infastructure.Repository
{
	public class BaseRepositoryAsync<T> : IRepositoryAsync<T> where T : class
	{
		private readonly MovieShopDbContext _context;
		public BaseRepositoryAsync(MovieShopDbContext c)
		{
			_context = c;
		}
		public async Task<int> DeleteAsync(int id)
		{
			var entity = await _context.Set<T>().FindAsync(id);
			if(entity != null)
			{
				_context.Set<T>().Remove(entity);
				return await _context.SaveChangesAsync();
			}
			return 0;
		}

		public virtual async Task<T> GetByIdAsync(int id)
		{
			return await _context.Set<T>().FindAsync(id);
		}

		public async Task<IEnumerable<T>> GetAllAsync()
		{
			return await _context.Set<T>().ToListAsync();
		}

		public async Task<int> InsertAsync(T entity)
		{
			await _context.Set<T>().AddAsync(entity);
			return await _context.SaveChangesAsync();
		}

		public async Task<int> UpdateAsync(T entity)
		{
			_context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
			return await _context.SaveChangesAsync();
		}
	}
}
