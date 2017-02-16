using Project.DAL.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.DAL;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Project.DAL.Common
{
    public interface IVehicleContext:IDisposable
    {
        DbSet<TEntity> Set<TEntity>() where TEntity : class;//DbSet represent collenction of all entities in context
        DbSet Set(Type entityType);
        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
        DbEntityEntry Entry(object entity);
        Task<int> SaveChangesAsync();


    }
}
