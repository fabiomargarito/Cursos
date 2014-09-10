using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SistemaMBCORPHealthTestsWeb.Startup))]
namespace SistemaMBCORPHealthTestsWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
