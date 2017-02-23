using Project.Reporsitory.Common;
using Project.Service.Common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Service
{
    public class VehicleMakeService : IVehicleMakeService
    {
        protected IVehicleMakeGenericReporsitory VehicleMakeGenericReporsitory { get; set; }
        public VehicleMakeService(IVehicleMakeGenericReporsitory vehicleMakeGenericReporsitory)
        {
            this.VehicleMakeGenericReporsitory = vehicleMakeGenericReporsitory;
        }

        public async Task<int> AddAsync<IVehicleMakeDomainModel>(IVehicleMakeDomainModel addObj)
        {
            return await VehicleMakeGenericReporsitory.AddAsync(addObj);
        }

        public async Task<int> DeleteAsync<IVehicleMakeDomainModel>(Guid Id)
        {
            return await VehicleMakeGenericReporsitory.DeleteAsync<IVehicleMakeDomainModel>(Id);
        }

        public async Task<IEnumerable<IVehicleMakeDomainModel>> GetAllAsync<IVehicleMakeDomainModel>()
        {
            return await VehicleMakeGenericReporsitory.GetAllAsync<IVehicleMakeDomainModel>();
        }

        public async Task<IVehicleMakeDomainModel> GetAsync<IVehicleMakeDomainModel>(Guid Id)
        {
            return await VehicleMakeGenericReporsitory.GetAsync<IVehicleMakeDomainModel>(Id);
        }

        public async Task<int> UpdateAsync<IVehicleMakeDomainModel>(IVehicleMakeDomainModel updated)
        {
            return await VehicleMakeGenericReporsitory.UpdateAsync(updated);
        }
    }
}
