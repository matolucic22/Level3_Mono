using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Reporsitory.Common
{
    public interface IVehicleModelGenericReporsitory
    {
        Task<IEnumerable<IVehicleModelDomainModel>> GetAllAsync<IVehicleModelDomainModel>();
        Task<int> GetAsync<IVehicleModelDomainModel>(Guid id);
        Task<int> AddAsync<IVehicleModelDomainModel>(IVehicleModelDomainModel addObj);
        Task<int> UpdateAsync<IVehicleModelDomainModel>(IVehicleModelDomainModel updated);
        Task<int> DeleteAsync<IVehicleModelDomainModel>(Guid id);
    }
}
