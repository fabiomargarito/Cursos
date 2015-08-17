using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebJBSHealthCare.Startup))]
namespace WebJBSHealthCare
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
