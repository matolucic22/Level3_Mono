﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using DAL;
using DAL.Models;

namespace Project.MVC.WebAPI.Controllers
{
    public class VehicleModelController : ApiController
    {
        private VehicleContext db = new VehicleContext();

        // GET: api/VehicleModel
        public IQueryable<VehicleModel> GetVehicleModels()
        {
            return db.VehicleModels;
        }

        // GET: api/VehicleModel/5
        [ResponseType(typeof(VehicleModel))]
        public async Task<IHttpActionResult> GetVehicleModel(Guid id)
        {
            VehicleModel vehicleModel = await db.VehicleModels.FindAsync(id);
            if (vehicleModel == null)
            {
                return NotFound();
            }

            return Ok(vehicleModel);
        }

        // PUT: api/VehicleModel/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutVehicleModel(Guid id, VehicleModel vehicleModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != vehicleModel.Id)
            {
                return BadRequest();
            }

            db.Entry(vehicleModel).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VehicleModelExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/VehicleModel
        [ResponseType(typeof(VehicleModel))]
        public async Task<IHttpActionResult> PostVehicleModel(VehicleModel vehicleModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.VehicleModels.Add(vehicleModel);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (VehicleModelExists(vehicleModel.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = vehicleModel.Id }, vehicleModel);
        }

        // DELETE: api/VehicleModel/5
        [ResponseType(typeof(VehicleModel))]
        public async Task<IHttpActionResult> DeleteVehicleModel(Guid id)
        {
            VehicleModel vehicleModel = await db.VehicleModels.FindAsync(id);
            if (vehicleModel == null)
            {
                return NotFound();
            }

            db.VehicleModels.Remove(vehicleModel);
            await db.SaveChangesAsync();

            return Ok(vehicleModel);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool VehicleModelExists(Guid id)
        {
            return db.VehicleModels.Count(e => e.Id == id) > 0;
        }
    }
}