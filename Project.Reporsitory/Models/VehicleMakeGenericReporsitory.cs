using Project.DAL.Common;
using Project.Model.Common;
using Project.Reporsitory.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DAL.Models;

namespace Project.Reporsitory.Models
{
    class VehicleMakeGenericReporsitory : IVehicleMakeGenericReporsitory
    {
        
        private IReporsitory _reporsitory;

    

        public VehicleMakeGenericReporsitory(Reporsitory repo)//dozvoljen pristup bazi podatka dependency injection
        {
            _reporsitory = repo;
        }


        public async Task<int> AddAsync<IVehicleMakeDomainModel>(IVehicleMakeDomainModel addObj)
        {
            return await _reporsitory.AddAsync(Mapper.Map<IVehicleMake>(addObj));
        }

        public async Task<int> DeleteAsync<IVehicleMakeDomainModel>(Guid id)
        {
            return await _reporsitory.DeleteAsync<IVehicleMake>(id);
        }

        public async Task<IEnumerable<IVehicleMakeDomainModel>> GetAllAsync<IVehicleMakeDomainModel>()
        {
            return Mapper.Map <IEnumerable<IVehicleMakeDomainModel>>(await _reporsitory.GetAllAsync<IVehicleMake>());
        }

        public async Task<IVehicleMakeDomainModel> GetAsync<IVehicleMakeDomainModel>(Guid id)
        {
            return Mapper.Map<IVehicleMakeDomainModel>(await _reporsitory.GetAsync<IVehicleMake>(id));
        }

        public async Task<int> UpdateAsync<IVehicleMakeDomainModel>(IVehicleMakeDomainModel updated)
        {
            return await _reporsitory.UpdateAsync(Mapper.Map<IVehicleMake>(updated));
        }

    }
}
