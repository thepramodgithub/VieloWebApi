using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vielo.Startup))]
namespace Vielo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
