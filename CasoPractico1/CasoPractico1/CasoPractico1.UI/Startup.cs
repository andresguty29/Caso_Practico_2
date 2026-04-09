using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(CasoPractico1.Startup))]

namespace CasoPractico1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
