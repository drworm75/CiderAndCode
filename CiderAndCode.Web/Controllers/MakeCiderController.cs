using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CiderAndCode.Web.DataModels;
using CiderAndCode.Web.ViewModels;

namespace CiderAndCode.Web.Controllers
{
    public class MakeCiderController : Controller
    {
        // GET: MakeCider
        public ActionResult Index()
        {
            ViewBag.Bushels = new AppDbContext().Bushels.ToList().Select(x =>
                new SelectListItem { Text = $"{x.User.Name}'s {x.Type} apples - {x.Quantity}", Value = x.Id.ToString() });

            return View();
        }

        public ActionResult DoIt(MakeCiderRequest req)
        {
            var db = new AppDbContext();

            var bushel = db.Bushels.Find(req.BushelId);
            var newCider = new Cider
            {
                Bushel = bushel,
                DatePressed = DateTime.Now,
                NumberOfGallons = bushel.Quantity * 3,
                Type = bushel.Type
            };

            db.Ciders.Add(newCider);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}