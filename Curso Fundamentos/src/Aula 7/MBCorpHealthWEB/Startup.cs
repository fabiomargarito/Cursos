using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MBCorpHealthWEB.Startup))]
namespace MBCorpHealthWEB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
