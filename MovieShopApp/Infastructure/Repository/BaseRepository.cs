using ApplicationCore.Contracts.Repository;
using Infastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infastructure.Repository
{
	public class BaseRepository<T> : IRepository<T> where T : class
	{
		private readonly MovieShopDbContext _context;
		public BaseRepository(MovieShopDbContext c)
		{
			_context = c;
		}
		public int Delete(int id)
		{
			var entity = GetById(id);
			if(entity != null)
			{
				_context.Set<T>().Remove(entity);
				return _context.SaveChanges();
			}
			return 0;
		}

		public T GetById(int id)
		{
			return _context.Set<T>().Find(id);
		}

		public IEnumerable<T> GetAll()
		{
			return _context.Set<T>().ToList();
		}

		public int Insert(T entity)
		{
			_context.Set<T>().Add(entity);
			return _context.SaveChanges();
		}

		public int Update(T entity)
		{
			_context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
			return _context.SaveChanges();
		}
	}
}
