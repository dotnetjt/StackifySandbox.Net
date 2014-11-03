using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HelloStackify.Web.Models;
using log4net;
using Microsoft.Ajax.Utilities;
using Newtonsoft.Json;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;

namespace HelloStackify.Web.Controllers
{
    public class GimmeErrorsController : Controller
    {

        private static readonly ILog log = LogManager.GetLogger(typeof(GimmeErrorsController).Name);

        // GET: GimmeErrors
        public ActionResult Index()
        {
            

            try
            {
                throw new NullReferenceException("Throwing a null reference exception on purpose.");
            }
            catch(Exception e)
            {
                log.Error(e);
            }
            FooOutputController ctrl = new FooOutputController();
            ctrl.CreateFoos(1,"The foo is 1");
            ctrl.CreateFoos(null, "The foo is null");
            
            return View();
        }

        public ActionResult NoView()
        {
            return View();
        }

    }
}