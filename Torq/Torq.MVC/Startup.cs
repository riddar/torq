using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Torq.MVC.Startup))]
namespace Torq.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
