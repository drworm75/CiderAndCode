using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace CiderAndCode.Web.Controllers
{
    [RoutePrefix("api/StealApples")]
    public class StealApplesController : ApiController
    {
        /*
        [Route(""), HttpPost]
        public HttpResponseMessage StoleDemApples(ApplesStolenRequest request)
        {
            var db = new AppDbContext();

            var deleteBushel = new BushelController
            {

            };

            db.Bushels.Delete(deleteBushel);
            db.SaveChanges();

            return Request.CreateResponse(HttpStatusCode.Moved, deleteBushel);

        }
        */
    }
}