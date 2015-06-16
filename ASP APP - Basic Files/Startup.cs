using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASP_APP___Basic_Files.Startup))]
namespace ASP_APP___Basic_Files
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
