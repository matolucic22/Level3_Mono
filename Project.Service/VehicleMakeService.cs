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
        private IVehicleMakeGenericReporsitory _VehicleMakeGenericReporsitory;

        public VehicleMakeService(IVehicleMakeGenericReporsitory VehicleMakeGenericReporsitory)
        {
            this._VehicleMakeGenericReporsitory = VehicleMakeGenericReporsitory;
        }

        public async Task<int> AddAsync<IVehicleMakeDomainModel>(IVehicleMakeDomainModel addObj)
        {
            return await _VehicleMakeGenericReporsitory.AddAsync(addObj);
        }

        public async Task<int> DeleteAsync<IVehicleMakeDomainModel>(Guid id)
        {
            return await _VehicleMakeGenericReporsitory.DeleteAsync<IVehicleMakeDomainModel>(id);
        }

        public async Task<IEnumerable<IVehicleMakeDomainModel>> GetAllAsync<IVehicleMakeDomainModel>()
        {
            return await  _VehicleMakeGenericReporsitory.GetAllAsync<IVehicleMakeDomainModel>();
        }

        public async Task<IVehicleMakeDomainModel> GetAsync<IVehicleMakeDomainModel>(Guid id)
        {
            return await _VehicleMakeGenericReporsitory.GetAsync<IVehicleMakeDomainModel>(id);
        }

        public async Task<int> UpdateAsync<IVehicleMakeDomainModel>(IVehicleMakeDomainModel updated)
        {
            return await _VehicleMakeGenericReporsitory.UpdateAsync(updated);
        }
    }
}
