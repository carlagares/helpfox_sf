using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(helpfoxapp.Startup))]
namespace helpfoxapp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
