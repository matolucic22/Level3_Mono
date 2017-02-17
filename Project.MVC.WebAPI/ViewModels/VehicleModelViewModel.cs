﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.MVC.WebAPI.ViewModels
{
    public class VehicleModelViewModel
    {
        public Guid Id { get; set; }
        public Guid VehicleMakeId { get; set; }
        public String Name { get; set; }
        public String Abrv { get; set; }

        //public virtual VehicleMake VehicleMake { get; set; }//poziva jedan make di je npr id=1; - 1 make ima vise modela. Zato što svaki model ima 1 make m
    }
}