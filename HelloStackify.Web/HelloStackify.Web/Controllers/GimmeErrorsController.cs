using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using log4net;

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
            
            return View();
        }

        public ActionResult NoView()
        {
            return View();
        }
    }
}