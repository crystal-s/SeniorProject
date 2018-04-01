using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BeeIdentified.Startup))]
namespace BeeIdentified
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
