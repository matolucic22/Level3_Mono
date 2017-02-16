using DAL;
using Project.DAL.Common;
using Project.Reporsitory.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Reporsitory
{
    public class UnitOfWork : IUnitOfWork
    {
        public IVehicleContext _context;
        private bool disposing;

        public UnitOfWork(IVehicleContext context)
        {
            _context = context;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Dispose(bool disposed)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            disposed = true;
        }



        public async Task<int> Save()
        {
            return await _context.SaveChangesAsync();
        }





        /*public Task<int> AddAsync<T>(T entity) where T : class
        {
            return _context.Set<T>().Add();
        }

        public Task<int> CommitAsync()
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync<T>(Guid id) where T : class
        {
            DbContext.Set<T>().Remove(entity);
        }

        public Task<int> DeleteAsync<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }*/

    }
}
