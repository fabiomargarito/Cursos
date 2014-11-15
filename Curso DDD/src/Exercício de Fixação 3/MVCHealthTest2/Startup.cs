using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCHealthTest2.Startup))]
namespace MVCHealthTest2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
