using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace HelloStackify.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        static log4net.ILog log = log4net.LogManager.GetLogger(typeof(MvcApplication));

        public override void Init()
        {
            base.Init();
            this.BeginRequest += MvcApplication_BeginRequest;
            this.AuthenticateRequest += MvcApplication_AuthenticateRequest;
        }

        void MvcApplication_AuthenticateRequest(object sender, EventArgs e)
        {
            try
            {
                log4net.LogicalThreadContext.Properties["User"] = User;
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        void MvcApplication_BeginRequest(object sender, EventArgs e)
        {

            //log4net.LogicalThreadContext.Properties["Request"] = new
            //{
            //    HostAddress = Request.UserHostAddress,
            //    Params = Request.Params
            //};

        }
    }
}
