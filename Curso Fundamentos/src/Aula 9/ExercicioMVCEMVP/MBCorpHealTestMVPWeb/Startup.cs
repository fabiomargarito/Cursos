using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MBCorpHealTestMVPWeb.Startup))]
namespace MBCorpHealTestMVPWeb
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
