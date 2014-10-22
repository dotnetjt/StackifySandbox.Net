using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using log4net;
using Newtonsoft.Json;


namespace HelloStackify.Web.Controllers
{
    public class HomeController : Controller
    {

        private static readonly ILog log = LogManager.GetLogger(typeof(HomeController).Name);

        public ActionResult Index()
        {
            

            if(User.Identity.IsAuthenticated)
            {
                log.Debug("User is authenticated");

            }
            HelloStackify.Web.Models.TestModels model = new Models.TestModels { TestBool = true, TestInt = 100, TestString = "Hello World" };
            log.Debug("Test model object", model);

            
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "So what exactly is this web app?";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Stackify";

            return View();
        }
    }
}