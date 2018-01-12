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
using DemoWebservice.Models;

namespace DemoWebservice.Controllers
{
    [RoutePrefix("api/lops")]
    public class LopsController : ApiController
    {
        private SinhVienModel db = new SinhVienModel();

        [Route("All")]
        // GET: api/Lops
        public IQueryable<Lop> GetLop()
        {
            return db.Lop;
        }

        // GET: api/Lops/5
        [ResponseType(typeof(Lop))]
        public async Task<IHttpActionResult> GetLop(string id)
        {
            Lop lop = await db.Lop.FindAsync(id);
            if (lop == null)
            {
                return NotFound();
            }

            return Ok(lop);
        }

        // PUT: api/Lops/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutLop(string id, Lop lop)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != lop.IdLop)
            {
                return BadRequest();
            }

            db.Entry(lop).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LopExists(id))
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

        // POST: api/Lops
        [ResponseType(typeof(Lop))]
        public async Task<IHttpActionResult> PostLop(Lop lop)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Lop.Add(lop);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (LopExists(lop.IdLop))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = lop.IdLop }, lop);
        }

        // DELETE: api/Lops/5
        [ResponseType(typeof(Lop))]
        public async Task<IHttpActionResult> DeleteLop(string id)
        {
            Lop lop = await db.Lop.FindAsync(id);
            if (lop == null)
            {
                return NotFound();
            }

            db.Lop.Remove(lop);
            await db.SaveChangesAsync();

            return Ok(lop);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool LopExists(string id)
        {
            return db.Lop.Count(e => e.IdLop == id) > 0;
        }
    }
}