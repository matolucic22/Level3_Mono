using AutoMapper;
using Project.Model.Common;
using Project.MVC.WebAPI.ViewModels;
using Project.Service.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Project.MVC.WebAPI.Controllers
{
    [RoutePrefix("api/VehicleModel")]
    public class VehicleModelController : ApiController
    {
        protected IVehicleModelService VehicleModelService { get; set; }

        public VehicleModelController(IVehicleModelService vehicleModelService)
        {
            this.VehicleModelService = vehicleModelService;
        }

        [HttpGet]
        [Route("getall")]
        public async Task<HttpResponseMessage> GetAllVehModel()
        {
            try
            {
                var response = Mapper.Map<IEnumerable<VehicleModelViewModel>>(await VehicleModelService.GetAllAsync<IVehicleModelDomainModel>());
                return Request.CreateResponse(HttpStatusCode.OK, response);
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e);
            }
        }

        [HttpGet]
        [Route("get")]
        public async Task<HttpResponseMessage> GetVehModel(Guid Id)
        {
            try
            {
                var response = Mapper.Map<VehicleMakeViewModel>(await VehicleModelService.GetAsync<IVehicleMakeDomainModel>(Id));
                return Request.CreateResponse(HttpStatusCode.OK, response);
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e);
            }
        }

        [HttpPost]
        [Route("add")]
        public async Task<HttpResponseMessage> AddVehMake(VehicleMakeViewModel AddObj)
        {
            try
            {
                AddObj.Id = Guid.NewGuid();
                var response = await VehicleModelService.AddAsync(Mapper.Map<IVehicleMakeDomainModel>(AddObj));
                return Request.CreateResponse(HttpStatusCode.OK, response);
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e);
            }
        }

        [HttpPut]
        [Route("update")]
        public async Task<HttpResponseMessage> UpdateVehMake(VehicleMakeViewModel AddObj, Guid Id)
        {
            try
            {
                VehicleMakeViewModel find = Mapper.Map<VehicleMakeViewModel>(await VehicleModelService.GetAsync<IVehicleMakeDomainModel>(Id));

                if (AddObj.Name == null || AddObj.Abrv == null)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Greska u unosu!");
                }
                else
                {
                    find.Name = AddObj.Name;
                    find.Abrv = AddObj.Abrv;
                }
                var response = await VehicleModelService.UpdateAsync(Mapper.Map<IVehicleMakeDomainModel>(AddObj));
                return Request.CreateResponse(HttpStatusCode.OK, response);
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e);
            }
        }

        [HttpDelete]
        [Route("delete")]
        public async Task<HttpResponseMessage> DeleteVehMake(Guid Id)
        {
            try
            {
                var response = await VehicleModelService.DeleteAsync<IVehicleMakeDomainModel>(Id);
                return Request.CreateResponse(HttpStatusCode.OK, response);
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e);
            }
        }

    }
}
