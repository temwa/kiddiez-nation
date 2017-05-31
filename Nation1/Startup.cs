using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Nation1.Startup))]
namespace Nation1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
