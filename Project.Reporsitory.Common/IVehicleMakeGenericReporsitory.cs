using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Reporsitory.Common
{
   public interface IVehicleMakeGenericReporsitory
    {
        Task<IEnumerable<IVehicleMakeDomainModel>> GetAllAsync<IVehicleMakeDomainModel>();
        Task<IVehicleMakeDomainModel> GetAsync<IVehicleMakeDomainModel>(Guid Id);
        Task<int> AddAsync<IVehicleMakeDomainModel>(IVehicleMakeDomainModel addObj);
        Task<int> UpdateAsync<IVehicleMakeDomainModel>(IVehicleMakeDomainModel updated);
        Task<int> DeleteAsync<IVehicleMakeDomainModel>(Guid Id);
    }
}
