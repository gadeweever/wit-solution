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
using WITTracker.Runtime;

namespace WITTracker.Controllers
{
    public class TeacherController : Controller
    {
        private WITContext db = new WITContext();

        // GET: Teacher
        public ActionResult Index(string searchQuery)
        {
            var teachers = db.Teachers.Include(t => t.Location).Include(t => t.PreferenceSubject);

            if(!string.IsNullOrEmpty(searchQuery))
            {
                teachers = teachers.Where(s => (s.FirstName + s.LastName).Contains(searchQuery));
            }
            return View(teachers.ToList());
        }

        // GET: Teacher/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Teacher teacher = db.Teachers.Find(id);
            if (teacher == null)
            {
                return HttpNotFound();
            }

            Globals.Email = teacher.Email;
            ViewBag.email = teacher.Email;
            return View(teacher);
        }

        // GET: Teacher/Create
        public ActionResult Create()
        {
            ViewBag.BuildingID = new SelectList(db.Buildings, "ID", "Name");
            ViewBag.SubjectID = new SelectList(db.Subjects, "ID", "Name");
            return View();
        }

        // POST: Teacher/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,FirstName,LastName,SubjectID,BuildingID,Email")] Teacher teacher)
        {
            if (ModelState.IsValid)
            {
                db.Teachers.Add(teacher);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.BuildingID = new SelectList(db.Buildings, "ID", "Name", teacher.BuildingID);
            ViewBag.SubjectID = new SelectList(db.Subjects, "ID", "Name", teacher.SubjectID);
            return View(teacher);
        }

        // GET: Teacher/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Teacher teacher = db.Teachers.Find(id);
            if (teacher == null)
            {
                return HttpNotFound();
            }
            ViewBag.BuildingID = new SelectList(db.Buildings, "ID", "Name", teacher.BuildingID);
            ViewBag.SubjectID = new SelectList(db.Subjects, "ID", "Name", teacher.SubjectID);
            return View(teacher);
        }

        // POST: Teacher/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,FirstName,LastName,SubjectID,BuildingID,Email")] Teacher teacher)
        {
            if (ModelState.IsValid)
            {
                db.Entry(teacher).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.BuildingID = new SelectList(db.Buildings, "ID", "Name", teacher.BuildingID);
            ViewBag.SubjectID = new SelectList(db.Subjects, "ID", "Name", teacher.SubjectID);
            return View(teacher);
        }

        // GET: Teacher/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Teacher teacher = db.Teachers.Find(id);
            if (teacher == null)
            {
                return HttpNotFound();
            }
            return View(teacher);
        }

        // POST: Teacher/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Teacher teacher = db.Teachers.Find(id);
            db.Teachers.Remove(teacher);
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
