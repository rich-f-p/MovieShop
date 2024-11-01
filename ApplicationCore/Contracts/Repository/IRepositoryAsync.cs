using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Contracts.Repository
{
	public interface IRepositoryAsync<T> where T : class
	{
		Task<T> GetByIdAsync(int id);
		Task<IEnumerable<T>> GetAllAsync();
		Task<int> InsertAsync(T entity);
		Task<int> UpdateAsync(T entity);
		Task<int> DeleteAsync(int id);
	}
}
