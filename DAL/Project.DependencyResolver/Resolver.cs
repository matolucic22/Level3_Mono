using DAL;
using DAL.Models;
using Ninject.Modules;
using Project.DAL.Common;
using Project.Model;
using Project.Model.Common;
using Project.Reporsitory;
using Project.Reporsitory.Common;
using Project.Reporsitory.Models;
using Project.Service;
using Project.Service.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DependencyResolver
{
    public class Resolver : NinjectModule
    {
        public override void Load()
        {
            
            Bind<IVehicleMakeService>().To<VehicleMakeService>();
            Bind<IVehicleModelService>().To<VehicleModelService>();

            Bind<IReporsitory>().To<Reporsitory.Reporsitory>();
            Bind<IVehicleMakeGenericReporsitory>().To<VehicleMakeGenericReporsitory>();
            Bind<IVehicleModelGenericReporsitory>().To<VehicleModelGenericReporsitory>();
            Bind<IUnitOfWork>().To<UnitOfWork>();

            Bind<IVehicleContext>().To<VehicleContext>();

          
        }
    }
}
