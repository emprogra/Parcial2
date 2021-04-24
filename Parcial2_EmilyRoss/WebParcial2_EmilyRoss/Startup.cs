using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebParcial2_EmilyRoss.Startup))]
namespace WebParcial2_EmilyRoss
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
