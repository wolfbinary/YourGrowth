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
using System.Web.Http.ModelBinding;
using System.Web.Http.OData;
using System.Web.Http.OData.Routing;
using YourGrowth.Common.Models;
using YourGrowth.DataAccess.Contexts;

namespace YourGrowth.Api.Controllers
{
    /*
    The WebApiConfig class may require additional changes to add a route for this controller. 
    Merge these statements into the Register method of the WebApiConfig class as applicable. 
    Note that OData URLs are case sensitive.

    using System.Web.Http.OData.Builder;
    using System.Web.Http.OData.Extensions;
    using YourGrowth.Common.Models;
    ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
    builder.EntitySet<Muscle>("Muscles");
    config.Routes.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());
    */
    public class MusclesController : ODataController
    {
        private YourGrowthContext db = new YourGrowthContext();

        // GET: odata/Muscles
        [EnableQuery]
        public IQueryable<Muscle> GetMuscles()
        {
            return db.Muscles;
        }

        // GET: odata/Muscles(5)
        [EnableQuery]
        public SingleResult<Muscle> GetMuscle([FromODataUri] int key)
        {
            return SingleResult.Create(db.Muscles.Where(muscle => muscle.MuscleId == key));
        }

        // PUT: odata/Muscles(5)
        public async Task<IHttpActionResult> Put([FromODataUri] int key, Delta<Muscle> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Muscle muscle = await db.Muscles.FindAsync(key);
            if (muscle == null)
            {
                return NotFound();
            }

            patch.Put(muscle);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MuscleExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(muscle);
        }

        // POST: odata/Muscles
        public async Task<IHttpActionResult> Post(Muscle muscle)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Muscles.Add(muscle);
            await db.SaveChangesAsync();

            return Created(muscle);
        }

        // PATCH: odata/Muscles(5)
        [AcceptVerbs("PATCH", "MERGE")]
        public async Task<IHttpActionResult> Patch([FromODataUri] int key, Delta<Muscle> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Muscle muscle = await db.Muscles.FindAsync(key);
            if (muscle == null)
            {
                return NotFound();
            }

            patch.Patch(muscle);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MuscleExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(muscle);
        }

        // DELETE: odata/Muscles(5)
        public async Task<IHttpActionResult> Delete([FromODataUri] int key)
        {
            Muscle muscle = await db.Muscles.FindAsync(key);
            if (muscle == null)
            {
                return NotFound();
            }

            db.Muscles.Remove(muscle);
            await db.SaveChangesAsync();

            return StatusCode(HttpStatusCode.NoContent);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool MuscleExists(int key)
        {
            return db.Muscles.Count(e => e.MuscleId == key) > 0;
        }
    }
}
