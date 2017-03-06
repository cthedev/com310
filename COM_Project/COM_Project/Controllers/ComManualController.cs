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

        public ActionResult TableOfContents()
        {
            return View(); 
        }

        public ActionResult StepOne()
        {
            return View("InstallingVisualStudio"); 
        }

        public ActionResult StepTwo()
        {
            return View("SetupWebsite"); 
        }

        public ActionResult StepThree()
        {
            return View("Understanding"); 
        }

        public ActionResult StepFour()
        {
            return View("AddingPages");
        }

        public ActionResult StepFive()
        {
            return View("RemovePages");
        }

        public ActionResult StepSix()
        {
            return View("Hosting"); 
        }

        public ActionResult StepSeven()
        {
            return View("Conclusion");
        }

        public ActionResult StepEight()
        {
            return View("Appendix");
        }
    }
}