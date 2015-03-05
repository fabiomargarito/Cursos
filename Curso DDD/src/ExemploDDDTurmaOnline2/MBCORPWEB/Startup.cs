using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MBCORPWEB.Startup))]
namespace MBCORPWEB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
