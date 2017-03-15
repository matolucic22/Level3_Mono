using DAL.Models;
using Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Model.Common;

namespace Project.Model
{
    public class VehicleModelDomainModel : IVehicleModelDomainModel
    {
        public string Abrv
        {
            get; set;
        }

        public Guid VehicleModelId
        {
            get; set;
        }

        public string Name
        {
            get;set;
        }

        public Guid VehicleMakeId
        {
            get;set;
        }
        public virtual IVehicleMakeDomainModel VehicleMake { get; set; }//poziva jedan make di je npr id=1; - 1 make ima vise modela. Zato što svaki model ima 1 make 

    }
}

