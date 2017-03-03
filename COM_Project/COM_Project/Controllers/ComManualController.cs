using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace COM_Project.Controllers
{
    public class ComManualController : Controller
    {
        public ActionResult Index()
        {
            return View("Main");
        }
    }
}