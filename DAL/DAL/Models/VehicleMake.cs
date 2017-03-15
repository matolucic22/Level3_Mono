using DAL.Models;
using Project.DAL.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class VehicleMake:IVehicleMake
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid VehicleMakeId { get; set; }
        public String Name { get; set; }
        public String Abrv { get; set; }

       //public virtual ICollection<IVehicleModel> VehicleModels { get; set; }//1 make ima vise modela
    }
}
