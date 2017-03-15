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
using System.Data.Entity.Migrations;

namespace Project.Reporsitory
{
    public class Reporsitory : IReporsitory
    {
        protected IVehicleContext Context { get; set; }
        
        public Reporsitory(IVehicleContext context)//dozvoljen pristup bazi podatka dependency injection
        {
            this.Context = context;
        }

        public async Task<int> AddAsync<T>(T addObj) where T : class
        {
            Context.Set<T>().Add(addObj);
            return await Context.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync<T>() where T : class
        {
            var response = await Context.Set<T>().ToListAsync();
            return response;
        }

        public async Task<T> GetAsync<T>(Guid Id) where T : class
        {
            var obj = Context.Set<T>().FindAsync(Id);
            return await obj;
        }

        public async Task<int> DeleteAsync<T>(Guid Id) where T : class
        {
            T entity = await GetAsync<T>(Id);
            Context.Set<T>().Remove(entity);
            return await Context.SaveChangesAsync();
        }

        public async Task<int> UpdateAsync<T>(T updated) where T : class
        {
            Context.Set<T>().AddOrUpdate<T>(updated);
            return await Context.SaveChangesAsync();
        }

       
    }
}
