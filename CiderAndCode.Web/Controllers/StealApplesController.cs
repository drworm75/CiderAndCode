﻿using CiderAndCode.Web.DataModels;
using CiderAndCode.Web.ViewModels;
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