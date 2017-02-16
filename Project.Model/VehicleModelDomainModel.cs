using DAL.Models;
using Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Model.Common;

namespace Project.Model
{
    public class VehicleModelDomainModel : IVehicleModelDomainModel
    {
        public string Abrv
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public Guid Id
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public string Name
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public Guid VehicleMakeId
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }
        public virtual VehicleMakeDomainModel VehicleMakesDomainModel { get; set; }//poziva jedan make di je npr id=1; - 1 make ima vise modela. Zato što svaki model ima 1 make 

    }
}

