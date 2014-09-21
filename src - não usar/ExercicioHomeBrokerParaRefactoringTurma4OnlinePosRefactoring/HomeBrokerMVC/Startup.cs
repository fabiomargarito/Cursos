using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HomeBrokerMVC.Startup))]
namespace HomeBrokerMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
