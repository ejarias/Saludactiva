using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Saludactiva.Backend.Startup))]
namespace Saludactiva.Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
