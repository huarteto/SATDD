using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(SATDD.Startup))]

namespace SATDD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}