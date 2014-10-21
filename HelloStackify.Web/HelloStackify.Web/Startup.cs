using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HelloStackify.Web.Startup))]
namespace HelloStackify.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
