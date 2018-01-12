using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.Description;
using DemoWebservice.Models;
using QuanLyTuyenSinh.Models;

namespace DemoWebservice.Controllers
{
    [RoutePrefix("api/sinhviens")]
    public class SinhViensController : ApiController
    {
        private SinhVienModel db = new SinhVienModel();

        [Route("All")]
        // GET: api/SinhViens
        public IQueryable<SinhVien> GetSinhVien()
        {


            return db.SinhVien;
        }


        public  async Task<IHttpActionResult> PostLogin(SinhVien sv)
        {
            SinhVien sinhVien = await db.SinhVien.FindAsync(sv.Id);
            if (sv.Name == sinhVien.Name)
                HttpContext.Current.Session["user"] = sv;

            return Ok();
        }

        // GET: api/SinhViens/5
        [ResponseType(typeof(SinhVien))]
        public async Task<IHttpActionResult> GetSinhVien(string id)
        {
            SinhVien sinhVien = await db.SinhVien.FindAsync(id);
            if (sinhVien == null)
            {
                return NotFound();
            }

            return Ok(sinhVien);
        }

        // PUT: api/SinhViens/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutSinhVien(string id, SinhVien sinhVien)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != sinhVien.Id)
            {
                return BadRequest();
            }

            db.Entry(sinhVien).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SinhVienExists(id))
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

        [Route("insert")]
        // POST: api/SinhViens
        [ResponseType(typeof(SinhVien))]
        public async Task<IHttpActionResult> PostSinhVien(SinhVien sinhVien)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.SinhVien.Add(sinhVien);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SinhVienExists(sinhVien.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return Json<SinhVien>(sinhVien); //CreatedAtRoute("DefaultApi", new { id = sinhVien.Id }, sinhVien);
        }
        
        // DELETE: api/SinhViens/5
        [ResponseType(typeof(SinhVien))]
        public async Task<IHttpActionResult> DeleteSinhVien(string id)
        {
            SinhVien sinhVien = await db.SinhVien.FindAsync(id);
            if (sinhVien == null)
            {
                return NotFound();
            }

            db.SinhVien.Remove(sinhVien);
            await db.SaveChangesAsync();

            return Ok(sinhVien);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SinhVienExists(string id)
        {
            return db.SinhVien.Count(e => e.Id == id) > 0;
        }
    }
}