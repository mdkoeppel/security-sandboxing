using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Home.Views.Modules
{
    public class ModuleController : Controller
    {
        //
        // GET: /Module/
        public ActionResult Modules()
        {
            ViewBag.Title = "| Welcome! |";
            return View();
        }
	}
}