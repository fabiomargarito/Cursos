using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MBCorpHealthTestMVC.Startup))]
namespace MBCorpHealthTestMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
