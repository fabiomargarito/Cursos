using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MBCorpHealthMVC.Startup))]
namespace MBCorpHealthMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
