using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ONoticiario.Startup))]
namespace ONoticiario
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
