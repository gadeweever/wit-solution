using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WITTracker.DAL;
using WITTracker.Runtime;

namespace WITTracker.Controllers
{
    public class HomeController : Controller
    {
        private WITContext db = new WITContext();

        public ActionResult Index()
        {
            var updates = db.Updates;
            ViewBag.Name = Globals.TeacherName;
            if (updates.ToList().Count <= 3)
            {
                var list = updates.ToList();
                list.Reverse();
                return View(list);
            }
            else
            {
                var list = updates.ToList().GetRange(updates.ToList().Count - 3, 3);
                list.Reverse();
                return View(list);
            }
                


        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}