using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SMARTUIMBCORP.Startup))]
namespace SMARTUIMBCORP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
