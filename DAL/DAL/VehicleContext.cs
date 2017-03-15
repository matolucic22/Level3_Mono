using DAL.Models;
using Project.DAL.Common;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class VehicleContext:DbContext,IVehicleContext
    {
        public VehicleContext() : base("VehicleContext")
        {
        }
         public DbSet<VehicleModel> VehicleModel { get; set; }
         public DbSet<VehicleMake> VehicleMake { get; set; }
       protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
     /*   public new DbSet<T> Set<T>() where T : class// potpuni sličko kontekstu. Nešto kao instanca za svaku bazu koju smo kreirali
        {
            return base.Set<T>();
        }*/

    }
}
