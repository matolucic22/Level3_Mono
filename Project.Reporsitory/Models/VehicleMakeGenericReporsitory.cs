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
    public class VehicleMakeGenericReporsitory : IVehicleMakeGenericReporsitory
    {
        
        protected IReporsitory Reporsitory { get; set; }

    

       public VehicleMakeGenericReporsitory(IReporsitory reporsitory)//dozvoljen pristup bazi podatka dependency injection
        {
            Reporsitory = reporsitory;
        }


        public async Task<int> AddAsync<IVehicleMakeDomainModel>(IVehicleMakeDomainModel addObj)
        {
            return await Reporsitory.AddAsync(Mapper.Map<VehicleMake>(addObj));
        }

        public async Task<int> DeleteAsync<IVehicleMakeDomainModel>(Guid Id)
        {
            return await Reporsitory.DeleteAsync<VehicleMake>(Id);
            
        }

        public async Task<IEnumerable<IVehicleMakeDomainModel>> GetAllAsync<IVehicleMakeDomainModel>()
        {
            var x = Mapper.Map<IEnumerable<IVehicleMakeDomainModel>>(await Reporsitory.GetAllAsync<VehicleMake>());
            return x;
        }

        public async Task<IVehicleMakeDomainModel> GetAsync<IVehicleMakeDomainModel>(Guid Id)
        {
            return Mapper.Map<IVehicleMakeDomainModel>(await Reporsitory.GetAsync<VehicleMake>(Id));
        }

        public async Task<int> UpdateAsync<IVehicleMakeDomainModel>(IVehicleMakeDomainModel updated)
        {
            return await Reporsitory.UpdateAsync(Mapper.Map<VehicleMake>(updated));
        }

    }
}
