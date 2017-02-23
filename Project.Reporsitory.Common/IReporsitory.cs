using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Reporsitory.Common
{
    public interface IReporsitory
    {
      /*  T GetById(object id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
       IQueryable<T> Table { get; }*/

        Task<IEnumerable<T>> GetAllAsync<T>() where T:class;
        Task<T> GetAsync<T>(Guid Id) where T : class;
        Task<int> AddAsync<T>(T addObj) where T : class;
        Task<int> UpdateAsync<T>(T updated) where T : class;
        Task<int> DeleteAsync<T>(Guid Id) where T : class;

    }
}
