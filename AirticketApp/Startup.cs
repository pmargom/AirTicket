using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AirticketApp.Startup))]
namespace AirticketApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
