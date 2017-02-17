using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Service.Common
{
    public interface IVehicleModelService
    {
        Task<IEnumerable<IVehicleModelDomainModel>> GetAllAsync<IVehicleModelDomainModel>();
        Task<IVehicleModelDomainModel> GetAsync<IVehicleModelDomainModel>(Guid id);
        Task<int> AddAsync<IVehicleModelDomainModel>(IVehicleModelDomainModel addObj);
        Task<int> UpdateAsync<IVehicleModelDomainModel>(IVehicleModelDomainModel updated);
        Task<int> DeleteAsync<IVehicleModelDomainModel>(Guid id);
    }
}
