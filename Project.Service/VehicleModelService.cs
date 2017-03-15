using Project.Reporsitory.Common;
using Project.Service.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Service
{
    public class VehicleModelService : IVehicleModelService
    {
        protected IVehicleModelGenericReporsitory _VehicleModelGenericReporsitory { get; set; }

        public VehicleModelService(IVehicleModelGenericReporsitory VehicleModelGenericReporsitory)
        {
            this._VehicleModelGenericReporsitory = VehicleModelGenericReporsitory;
        }

        public async Task<int> AddAsync<IVehicleModelDomainModel>(IVehicleModelDomainModel addObj)
        {
            return await _VehicleModelGenericReporsitory.AddAsync(addObj);
        }

        public async Task<int> DeleteAsync<IVehicleModelDomainModel>(Guid id)
        {
            return await _VehicleModelGenericReporsitory.DeleteAsync<IVehicleModelDomainModel>(id);
        }

        public async Task<IEnumerable<IVehicleModelDomainModel>> GetAllAsync<IVehicleModelDomainModel>()
        {
            var asd = _VehicleModelGenericReporsitory.GetAllAsync<IVehicleModelDomainModel>();
            return await asd; /*_VehicleModelGenericReporsitory.GetAllAsync<IVehicleModelDomainModel>();*/
        }

        public async Task<IVehicleModelDomainModel> GetAsync<IVehicleModelDomainModel>(Guid id)
        {
            return await _VehicleModelGenericReporsitory.GetAsync<IVehicleModelDomainModel>(id);
        }

        public async Task<int> UpdateAsync<IVehicleModelDomainModel>(IVehicleModelDomainModel updated)
        {
            return await _VehicleModelGenericReporsitory.UpdateAsync(updated);
        }
    }
}
