using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HelloWebFroms.Startup))]
namespace HelloWebFroms
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
