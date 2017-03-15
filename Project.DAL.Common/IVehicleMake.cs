using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Common
{
    public interface IVehicleMake
    {
        Guid VehicleMakeId { get; set; }
        String Name { get; set; }
        String Abrv { get; set; }
    
       // ICollection<IVehicleModel> VehicleModels { get; set; }
    }
}
