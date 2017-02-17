using System;
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
using Project.Service;
using Project.Reporsitory.Common;
using Project.Service.Common;

namespace Project.MVC.WebAPI.Controllers
{
    public class VehicleMakeController : ApiController
    {
        private VehicleContext db = new VehicleContext();
        IVehicleMakeService _IVehicleMakeService;
        public VehicleMakeController(IVehicleMakeService IVehicleMakeService)
        {
            this._IVehicleMakeService = IVehicleMakeService;
        }

        // GET: api/VehicleMake
        public IQueryable<VehicleMake> GetVehicleMakes()
        {
            return db.VehicleMakes;
        }

        // GET: api/VehicleMake/5
        [ResponseType(typeof(VehicleMake))]
        public async Task<IHttpActionResult> GetVehicleMake(Guid id)
        {
            

            if(_IVehicleMakeService == null)
            {
                return NotFound();
            }

            return Ok(_IVehicleMakeService);

            /* VehicleMake vehicleMake = await db.VehicleMakes.FindAsync(id);
             if (vehicleMake == null)
             {
                 return NotFound();
             }

             return Ok(vehicleMake);*/
        }

        // PUT: api/VehicleMake/5
        [ResponseType(typeof(void))]//update
        public async Task<IHttpActionResult> PutVehicleMake(Guid id, VehicleMake vehicleMake)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != vehicleMake.Id)
            {
                return BadRequest();
            }

            db.Entry(vehicleMake).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VehicleMakeExists(id))
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

        // POST: api/VehicleMake    
        [ResponseType(typeof(VehicleMake))]//add
        public async Task<IHttpActionResult> PostVehicleMake(VehicleMake vehicleMake)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.VehicleMakes.Add(vehicleMake);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (VehicleMakeExists(vehicleMake.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = vehicleMake.Id }, vehicleMake);
        }

        // DELETE: api/VehicleMake/5
        [ResponseType(typeof(VehicleMake))]
        public async Task<IHttpActionResult> DeleteVehicleMake(Guid id)
        {
            VehicleMake vehicleMake = await db.VehicleMakes.FindAsync(id);
            if (vehicleMake == null)
            {
                return NotFound();
            }

            db.VehicleMakes.Remove(vehicleMake);
            await db.SaveChangesAsync();

            return Ok(vehicleMake);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool VehicleMakeExists(Guid id)
        {
            return db.VehicleMakes.Count(e => e.Id == id) > 0;
        }
    }
}