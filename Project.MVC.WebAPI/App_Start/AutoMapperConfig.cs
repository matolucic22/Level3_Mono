using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Project.Model;
using Project.Model.Common;
using Project.MVC.WebAPI.ViewModels;

namespace Project.MVC.WebAPI.App_Start
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(cfg =>
            {
            //    cfg.CreateMap<VehicleMake, VehicleMakeDomainModel>().ReverseMap();//source-destination
            //    cfg.CreateMap<VehicleMake, IVehicleMakeDomainModel>().ReverseMap();


            //    cfg.CreateMap<VehicleModel, VehicleModelDomainModel>().ReverseMap();
            //    cfg.CreateMap<VehicleModel, IVehicleModelDomainModel>().ReverseMap();


                cfg.CreateMap<IVehicleModelDomainModel, VehicleModelViewModel>().ReverseMap();


                cfg.CreateMap<IVehicleMakeDomainModel, VehicleMakeViewModel>().ReverseMap();
            });

        }
    }
}