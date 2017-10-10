using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CiderAndCode.Web.DataModels;

namespace CiderAndCode.Web.Controllers
{
    public class AppleFactsController : Controller
    {
        private AppDbContext db = new AppDbContext();

        // GET: AppleFacts
        public ActionResult Index()
        {
            return View(db.AppleFacts.ToList());
        }

        // GET: AppleFacts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AppleFact appleFact = db.AppleFacts.Find(id);
            if (appleFact == null)
            {
                return HttpNotFound();
            }
            return View(appleFact);
        }

        // GET: AppleFacts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AppleFacts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Type,Fact")] AppleFact appleFact)
        {
            if (ModelState.IsValid)
            {
                db.AppleFacts.Add(appleFact);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(appleFact);
        }

        // GET: AppleFacts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AppleFact appleFact = db.AppleFacts.Find(id);
            if (appleFact == null)
            {
                return HttpNotFound();
            }
            return View(appleFact);
        }

        // POST: AppleFacts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Type,Fact")] AppleFact appleFact)
        {
            if (ModelState.IsValid)
            {
                db.Entry(appleFact).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(appleFact);
        }

        // GET: AppleFacts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AppleFact appleFact = db.AppleFacts.Find(id);
            if (appleFact == null)
            {
                return HttpNotFound();
            }
            return View(appleFact);
        }

        // POST: AppleFacts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AppleFact appleFact = db.AppleFacts.Find(id);
            db.AppleFacts.Remove(appleFact);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
