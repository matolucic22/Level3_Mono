using Project.DAL.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class VehicleModel:IVehicleModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid VehicleModelId { get; set; }
        public virtual Guid VehicleMakeId { get; set; }
        public String Name { get; set; }
        public String Abrv { get; set; }

      public virtual VehicleMake VehicleMake { get; set; }//poziva jedan make di je npr id=1; - 1 make ima vise modela. Zato što svaki model ima 1 make m
    }
}
