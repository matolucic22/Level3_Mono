using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class VehicleContext:DbContext
    {
        public VehicleContext() : base("VehicleContext")
        {
        }
          public DbSet<VehicleModel> VehicleModels { get; set; }
          public DbSet<VehicleMake> VehicleMakes { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}
