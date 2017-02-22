using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class VehicleInitializer: System.Data.Entity.DropCreateDatabaseIfModelChanges<VehicleContext>
    {
        protected override void Seed(VehicleContext context)
         {
             var VehicleMakes = new List<VehicleMake>
             {
                 new VehicleMake {Id = Guid.NewGuid() ,Name="Skoda", Abrv="Skoda"}

             };

             VehicleMakes.ForEach(v => context.VehicleMakes.Add(v));
             context.SaveChanges();

             var VehicleModels = new List<VehicleModel>
             {
                 new VehicleModel {Id = Guid.NewGuid() , Name="Bla", Abrv="BBB" }

             };
             VehicleModels.ForEach(v => context.VehicleModels.Add(v));
             context.SaveChanges();
         }
    }
}
