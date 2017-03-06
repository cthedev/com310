using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace COM_Project
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Manual",
                "manual",
                new { controller = "ComManual", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                "TableOfContents", 
                "toc",
                new { controller = "ComManual", action="TableOfContents"}
            );

            routes.MapRoute(
                "Step1",
                "Steps/1",
                new { controller = "ComManual", action = "StepOne" }
            );

            routes.MapRoute(
                "Step2",
                "Steps/2",
                new { controller = "ComManual", action = "StepTwo" }
            );

            routes.MapRoute(
                "Step3",
                "Steps/3",
                new { controller = "ComManual", action = "StepThree" }
            );

            routes.MapRoute(
                "Step4",
                "Steps/4",
                new { controller = "ComManual", action = "StepFour" }
            );

            routes.MapRoute(
                "Step5",
                "Steps/5",
                new { controller = "ComManual", action = "StepFive" }
            );

            routes.MapRoute(
                "Step6",
                "Steps/6",
                new { controller = "ComManual", action = "StepSix" }
            );

            routes.MapRoute(
                "Step7",
                "Steps/Conclusion",
                new { controller = "ComManual", action = "StepSeven" }
            );

            routes.MapRoute(
                "Appendix",
                "Appendix",
                new { controller = "ComManual", action = "StepEight" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            ); 
        }
    }
}
