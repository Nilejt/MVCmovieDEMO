using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCmovieDEMO.Startup))]
namespace MVCmovieDEMO
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
