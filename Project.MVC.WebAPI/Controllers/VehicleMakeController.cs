﻿using AutoMapper;
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
    [RoutePrefix("api/VehicleMake")]
    public class VehicleMakeController : ApiController
    {
        protected IVehicleMakeService VehicleMakeService { get; set; }

        public VehicleMakeController(IVehicleMakeService vehicleMakeService)
        {
            this.VehicleMakeService = vehicleMakeService;
        }

        [HttpGet]
        [Route("getall")]
        public async Task<HttpResponseMessage> GetAll()
        {
            try
            {
                var response = Mapper.Map<IEnumerable<VehicleMakeViewModel>>(await VehicleMakeService.GetAllAsync<IVehicleMakeDomainModel>());
                return Request.CreateResponse(HttpStatusCode.OK, response);
            }
            catch(Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e);
            }
        }

        [HttpGet]
        [Route("get")]
        public async Task<HttpResponseMessage> Get(Guid Id)
        {
            try
            {
                var response = Mapper.Map<VehicleMakeViewModel>(await VehicleMakeService.GetAsync< IVehicleMakeDomainModel>(Id));
                return Request.CreateResponse(HttpStatusCode.OK, response);
            }
            catch(Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e);
            }
        }




    }
}
