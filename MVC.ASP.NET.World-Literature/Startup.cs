using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC.ASP.NET.World_Literature.Startup))]
namespace MVC.ASP.NET.World_Literature
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
