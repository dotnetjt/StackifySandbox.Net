using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HelloStackify.Web.Models;
using log4net;

namespace HelloStackify.Web.Controllers
{
    public class FooOutputController : Controller
    {

        private static readonly ILog log = LogManager.GetLogger(typeof(GimmeErrorsController).Name);

        // GET: FooOutput
        public ActionResult Index()
        {

            using (var context = new ApplicationDbContext())
            {
                var foos = (from x in context.Foos
                            select x);

                return View(foos.ToList());

            }


        }
        [HttpPost]
        [Authorize]
        public ActionResult Create(Foo model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    
                    CreateFoos(model.RequiredInt, model.FooString);
                }
                else
                {
                    log.Error("Model not valid",new {Foo = model});
                    ModelState.AddModelError("","Model not valid");
                }
            }
            catch (Exception ex)
            {
                log.Error("Error creating foo: ", ex);
            }

            return View();

        }

        public ActionResult Create()
        {
            return View();
        }


        public void CreateFoos(int? requiredInt, string fooString)
        {
            log.Debug("Attempt to create foo: ", new Foo { RequiredInt = (int)requiredInt, FooString = fooString });
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    var foo = new Foo();
                    foo.RequiredInt = (int)requiredInt;
                    foo.FooString = fooString;
                    context.Foos.Add(foo);
                    context.SaveChanges();
                    log.Debug("Created a Foo", foo);

                }
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }


        }
    }
}