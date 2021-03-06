﻿using System;
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
    public class StudentController : Controller
    {
        private WITContext db = new WITContext();

        // GET: Student
        public ActionResult Index(string searchQuery)
        {
            var students = db.Students.Include(s => s.Teacher);
            

            if(!String.IsNullOrEmpty(searchQuery))
            {
                students = students.Where(s => (s.FirstName + s.LastName).Contains(searchQuery));
            }
            ComputeAverages(students.ToList());
            return View(students.ToList());
        }

        // GET: Student/Details/5
        public ActionResult Details(int? id)
        {
            
            
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = db.Students.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            var students = db.Students.Include(s => s.Teacher);

            SetViewBag();
            return View(student);
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            ViewBag.TeacherID = new SelectList(db.Teachers, "ID", "FirstName");
            return View();
        }

        // POST: Student/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,FirstName,LastName,TeacherID")] Student student)
        {
            if (ModelState.IsValid)
            {
                db.Students.Add(student);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.TeacherID = new SelectList(db.Teachers, "ID", "FirstName", student.TeacherID);
            return View(student);
        }

        // GET: Student/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = db.Students.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            ViewBag.TeacherID = new SelectList(db.Teachers, "ID", "FirstName", student.TeacherID);
            return View(student);
        }

        // POST: Student/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,FirstName,LastName,TeacherID")] Student student)
        {
            if (ModelState.IsValid)
            {
                db.Entry(student).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.TeacherID = new SelectList(db.Teachers, "ID", "FirstName", student.TeacherID);
            return View(student);
        }

        // GET: Student/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = db.Students.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // POST: Student/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Student student = db.Students.Find(id);
            db.Students.Remove(student);
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

        private void ComputeAverages(List<Student> students)
        {   
            Globals.CompositeAverage = ComputeAverageOfElement(students, 5);
            Globals.EnglishAverage = ComputeAverageOfElement(students, 0);
            Globals.MathAverage = ComputeAverageOfElement(students, 1);
            Globals.WritingAverage = ComputeAverageOfElement(students, 2);
            Globals.ReadingAverage = ComputeAverageOfElement(students, 3);
            Globals.ScienceAverage = ComputeAverageOfElement(students, 4);

            SetViewBag();

        }

        private int ComputeAverageOfElement(List<Student> students, int at)
        {
            int total = 0;
            foreach (Student student in students)
                total += student.Grades.ElementAt(at).Score;

            return total / students.Count;
        }

        private void SetViewBag()
        {
            ViewBag.CompositeAverage = Globals.CompositeAverage;
            ViewBag.EnglishAverage = Globals.EnglishAverage;
            ViewBag.MathAverage = Globals.MathAverage;
            ViewBag.WritingAverage = Globals.WritingAverage;
            ViewBag.ReadingAverage = Globals.ReadingAverage;
            ViewBag.ScienceAverage = Globals.ScienceAverage;
        }
    }
}
