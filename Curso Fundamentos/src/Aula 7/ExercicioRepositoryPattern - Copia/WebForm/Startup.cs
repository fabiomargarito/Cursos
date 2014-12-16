using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebForm.Startup))]
namespace WebForm
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
