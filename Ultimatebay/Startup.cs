using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ultimatebay.Startup))]
namespace Ultimatebay
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
