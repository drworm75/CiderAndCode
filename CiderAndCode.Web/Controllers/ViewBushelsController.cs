using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CiderAndCode.Web.DataModels;
using CiderAndCode.Web.ViewModels;
using System.Data.Entity;

namespace CiderAndCode.Web.Controllers
{
    [RoutePrefix("api/viewBushels")]
    public class ViewBushelsController : ApiController
    {
        [HttpGet, Route("")]
        public HttpResponseMessage GetAllBushels()
        {
            var db = new AppDbContext();

            var bushels = db.Bushels.Select(bushel => new AppleResult
            {
                Id = bushel.Id, 
                TypeOfApple = bushel.Type.ToString(),
                NumberOfBushels = bushel.Quantity,
                ContributingUser = bushel.User.Name
            });

            return Request.CreateResponse(HttpStatusCode.OK, bushels);

        }



    }
}

    
