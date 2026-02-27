using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMS.DAL.Repository
{
    public interface IGenericRepository<T>
    {
        Task<T> Add(T entity);
        Task Update(T entity);
        Task<bool> Delete(T entity);
        Task<T> GetById(long id);
        Task<IEnumerable<T>> GetAll();
    }
}
