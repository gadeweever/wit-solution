using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WITTracker.Runtime;

namespace WITTracker.Controllers
{
    public class EmailController : Controller
    {
        // GET: Email
        public ActionResult Index()
        {
            ViewBag.email = Globals.Email;
            return View();
        }
    }
}