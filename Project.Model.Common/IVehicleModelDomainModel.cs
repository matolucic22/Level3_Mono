using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Model.Common
{
   public interface IVehicleModelDomainModel
    {
         Guid VehicleModelId { get; set; }
         Guid VehicleMakeId { get; set; }
         String Name { get; set; }
         String Abrv { get; set; }

        
    }
}
