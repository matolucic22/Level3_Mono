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
                 new VehicleMake {VehicleMakeId = Guid.NewGuid() ,Name="Skoda", Abrv="Skoda"}

             };

             VehicleMakes.ForEach(v => context.VehicleMake.Add(v));
             context.SaveChanges();

             var VehicleModels = new List<VehicleModel>
             {
                 new VehicleModel {VehicleModelId = Guid.NewGuid() , VehicleMakeId = VehicleMakes.First().VehicleMakeId, Name="Bla", Abrv="BBB" }

             };
             VehicleModels.ForEach(v => context.VehicleModel.Add(v));
             context.SaveChanges();
         }
    }
}
