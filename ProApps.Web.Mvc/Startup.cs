using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProApps.Web.Mvc.Startup))]
namespace ProApps.Web.Mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
