using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Identety.Startup))]
namespace Identety
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
