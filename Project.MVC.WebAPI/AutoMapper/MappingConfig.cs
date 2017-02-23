using AutoMapper;
using Project.Model;
using Project.Model.Common;
using Project.MVC.WebAPI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.MVC.WebAPI.AutoMapper
{
    public class MappingConfig : Profile
    {
        protected override void Configure()
        {
            //Domain to View
            CreateMap<VehicleMakeDomainModel, VehicleMakeViewModel>().ReverseMap();
            //CreateMap<VehicleMakeDomain, IVehicleMakeView>().ReverseMap();
            CreateMap<VehicleMakeDomainModel, IVehicleMakeDomainModel>().ReverseMap();
            //CreateMap<IVehicleMakeDomain, IVehicleMakeView>().ReverseMap();
            CreateMap<IVehicleMakeDomainModel, VehicleMakeViewModel>().ReverseMap();


            CreateMap<VehicleModelDomainModel, VehicleModelViewModel>().ReverseMap();
            //CreateMap<VehicleModelDomain, IVehicleModelView>().ReverseMap();
            CreateMap<VehicleModelDomainModel, IVehicleModelDomainModel>().ReverseMap();
            //CreateMap<IVehicleModelDomain, IVehicleModelView>().ReverseMap();
            CreateMap<IVehicleModelDomainModel, VehicleModelViewModel>().ReverseMap();

            
        }
    }
}