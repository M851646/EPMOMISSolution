using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EPMOMISSolution.Startup))]
namespace EPMOMISSolution
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
