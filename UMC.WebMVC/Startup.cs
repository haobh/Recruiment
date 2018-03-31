using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UMC.WebMVC.Startup))]
namespace UMC.WebMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
