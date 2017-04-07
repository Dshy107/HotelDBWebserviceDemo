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
using HotelDBWebserviceDemo;

namespace HotelDBWebserviceDemo.Controllers
{
    public class HotelDemoViewsController : ApiController
    {
        private HotelViewContext db = new HotelViewContext();

        // GET: api/HotelDemoViews
        public IQueryable<HotelDemoView> GetHotelDemoView()
        {
            return db.HotelDemoView;
        }

        // GET: api/HotelDemoViews/5
        [ResponseType(typeof(HotelDemoView))]
        public async Task<IHttpActionResult> GetHotelDemoView(int id)
        {
            HotelDemoView hotelDemoView = await db.HotelDemoView.FindAsync(id);
            if (hotelDemoView == null)
            {
                return NotFound();
            }

            return Ok(hotelDemoView);
        }

        //// PUT: api/HotelDemoViews/5
        //[ResponseType(typeof(void))]
        //public async Task<IHttpActionResult> PutHotelDemoView(int id, HotelDemoView hotelDemoView)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != hotelDemoView.Hotel_No)
        //    {
        //        return BadRequest();
        //    }

        //    db.Entry(hotelDemoView).State = EntityState.Modified;

        //    try
        //    {
        //        await db.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!HotelDemoViewExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return StatusCode(HttpStatusCode.NoContent);
        //}

        //// POST: api/HotelDemoViews
        //[ResponseType(typeof(HotelDemoView))]
        //public async Task<IHttpActionResult> PostHotelDemoView(HotelDemoView hotelDemoView)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    db.HotelDemoView.Add(hotelDemoView);

        //    try
        //    {
        //        await db.SaveChangesAsync();
        //    }
        //    catch (DbUpdateException)
        //    {
        //        if (HotelDemoViewExists(hotelDemoView.Hotel_No))
        //        {
        //            return Conflict();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return CreatedAtRoute("DefaultApi", new { id = hotelDemoView.Hotel_No }, hotelDemoView);
        //}

        //// DELETE: api/HotelDemoViews/5
        //[ResponseType(typeof(HotelDemoView))]
        //public async Task<IHttpActionResult> DeleteHotelDemoView(int id)
        //{
        //    HotelDemoView hotelDemoView = await db.HotelDemoView.FindAsync(id);
        //    if (hotelDemoView == null)
        //    {
        //        return NotFound();
        //    }

        //    db.HotelDemoView.Remove(hotelDemoView);
        //    await db.SaveChangesAsync();

        //    return Ok(hotelDemoView);
        //}

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool HotelDemoViewExists(int id)
        {
            return db.HotelDemoView.Count(e => e.Hotel_No == id) > 0;
        }
    }
}