﻿using AutoMapper;
using DAL.Models;
using Project.DAL.Common;
using Project.Reporsitory.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Reporsitory.Models
{
    class VehicleModelGenericReporsitory : IVehicleModelGenericReporsitory
    {
        private Reporsitory _reporsitory;
        private VehicleModelGenericReporsitory(Reporsitory reporsitory)
        {
            _reporsitory = reporsitory;
        }
        public async Task<int> AddAsync<IVehicleModelDomainModel>(IVehicleModelDomainModel addObj)
        {
            return await _reporsitory.AddAsync(Mapper.Map<IVehicleModel>(addObj));
        }

        public async Task<int> DeleteAsync<IVehicleModelDomainModel>(Guid id)
        {
            return await _reporsitory.DeleteAsync<IVehicleModel>(id);
        }

        public async Task<IEnumerable<IVehicleModelDomainModel>> GetAllAsync<IVehicleModelDomainModel>()
        {
            return Mapper.Map<IEnumerable<IVehicleModelDomainModel>>(await _reporsitory.GetAllAsync<IVehicleModel>());

        }

        public async Task<IVehicleModelDomainModel> GetAsync<IVehicleModelDomainModel>(Guid id)
        {
            return Mapper.Map<IVehicleModelDomainModel>(await _reporsitory.GetAsync<IVehicleModel>(id));
        }

        public async Task<int> UpdateAsync<IVehicleModelDomainModel>(IVehicleModelDomainModel updated)
        {
            return await _reporsitory.UpdateAsync(Mapper.Map<IVehicleModel>(updated));
        }
    }
}