using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WITTracker.DAL;
using WITTracker.Models;

namespace WITTracker.Controllers
{
    public class UpdateController : Controller
    {
        private WITContext db = new WITContext();

        // GET: Update
        public ActionResult Index()
        {
            var updates = db.Updates.Include(u => u.Author);
            return View(updates.ToList());
        }

        // GET: Update/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Update update = db.Updates.Find(id);
            if (update == null)
            {
                return HttpNotFound();
            }
            return View(update);
        }

        // GET: Update/Create
        public ActionResult Create()
        {
            ViewBag.TeacherID = new SelectList(db.Teachers, "ID", "FirstName");
            return View();
        }

        // POST: Update/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Header,Text,TimePosted,TeacherID")] Update update)
        {
            if (ModelState.IsValid)
            {
                db.Updates.Add(update);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.TeacherID = new SelectList(db.Teachers, "ID", "FirstName", update.TeacherID);
            return View(update);
        }

        // GET: Update/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Update update = db.Updates.Find(id);
            if (update == null)
            {
                return HttpNotFound();
            }
            ViewBag.TeacherID = new SelectList(db.Teachers, "ID", "FirstName", update.TeacherID);
            return View(update);
        }

        // POST: Update/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Header,Text,TimePosted,TeacherID")] Update update)
        {
            if (ModelState.IsValid)
            {
                db.Entry(update).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.TeacherID = new SelectList(db.Teachers, "ID", "FirstName", update.TeacherID);
            return View(update);
        }

        // GET: Update/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Update update = db.Updates.Find(id);
            if (update == null)
            {
                return HttpNotFound();
            }
            return View(update);
        }

        // POST: Update/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Update update = db.Updates.Find(id);
            db.Updates.Remove(update);
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
