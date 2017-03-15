using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.MVC.WebAPI.ViewModels
{
    public class VehicleMakeViewModel
    {
        public Guid VehicleMakeId { get; set; }
        public String Name { get; set; }
        public String Abrv { get; set; }

         //public virtual ICollection<VehicleModelViewModel> VehicleModel { get; set; }//1 make ima vise modela
    }
}