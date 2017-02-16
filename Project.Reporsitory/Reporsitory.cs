using DAL;
using Project.DAL.Common;
using Project.DAL;
using Project.Reporsitory.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Project.Reporsitory
{
    public class Reporsitory : IReporsitory
    {
        private readonly IVehicleContext _context;
        
        public Reporsitory(IVehicleContext context)//dozvoljen pristup bazi podatka dependency injection
        {
            this._context = context;
        }

        public async Task<int> AddAsync<T>(T addObj) where T : class
        {
            _context.Set<T>().Add(addObj);
            return await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync<T>() where T : class
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetAsync<T>(Guid id) where T : class
        {
            var obj = _context.Set<T>().FindAsync(id);
            return await obj;
        }

        public async Task<int> DeleteAsync<T>(Guid id) where T : class
        {
            T entity = await GetAsync<T>(id);
            _context.Set<T>().Remove(entity);
            return await _context.SaveChangesAsync();
            
        }

        public async Task<int> UpdateAsync<T>(T updated) where T : class
        {
            _context.Entry(updated).State = EntityState.Modified;
            return await _context.SaveChangesAsync();
        }
    }
}
