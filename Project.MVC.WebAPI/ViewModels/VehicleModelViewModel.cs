using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project.MVC.WebAPI.ViewModels;

namespace Project.MVC.WebAPI.ViewModels
{
    public class VehicleModelViewModel
    {
        public Guid VehicleModelId { get; set; }


        public Guid VehicleMakeId { get; set; }
        public String Name { get; set; }
        public String Abrv { get; set; }

      public virtual VehicleMakeViewModel VehicleMake { get; set; }//poziva jedan make di je npr id=1; - 1 make ima vise modela. Zato što svaki model ima 1 make m
    }
}