using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Contracts.Repository
{
	public interface IRepository<T> where T : class
	{
		T GetById(int id);
		IEnumerable<T> GetAll();
		int Insert(T entity);
		int Update(T entity);
		int Delete(int id);
	}
}
