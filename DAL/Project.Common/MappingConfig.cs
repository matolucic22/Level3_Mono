using AutoMapper;
using DAL.Models;
using Project.DAL.Common;
using Project.Model;
using Project.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Common
{
    public class MappingConfig : Profile
    {
        protected override void Configure()
        {

            CreateMap<VehicleMake, VehicleMakeDomainModel>().ReverseMap();
            CreateMap<VehicleMake, IVehicleMakeDomainModel>().ReverseMap();
            CreateMap<VehicleMake, IVehicleMake>().ReverseMap();
          
            CreateMap<VehicleModel, VehicleModelDomainModel>().ReverseMap();
            CreateMap<VehicleModel, IVehicleModelDomainModel>().ReverseMap();
            CreateMap<VehicleModel, IVehicleModel>().ReverseMap();

            CreateMap<IVehicleMake, IVehicleMakeDomainModel>().ReverseMap();
            CreateMap<VehicleMakeDomainModel, IVehicleMakeDomainModel>().ReverseMap();
            CreateMap<IVehicleModel, IVehicleModelDomainModel>().ReverseMap();
            CreateMap<VehicleModelDomainModel, IVehicleModelDomainModel>().ReverseMap();

        }
    }
}
