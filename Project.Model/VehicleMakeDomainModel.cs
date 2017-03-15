using DAL.Models;
using Project.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Model
{
    public class VehicleMakeDomainModel:IVehicleMakeDomainModel
    {
            public Guid VehicleMakeId { get; set; }
            public String Name { get; set; }
            public String Abrv { get; set; }

            public virtual ICollection<IVehicleModelDomainModel> VehicleModels { get; set; }//1 make ima vise modela
        
    }
}
