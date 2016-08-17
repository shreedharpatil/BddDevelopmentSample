using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BddDevelopmentSample.Startup))]
namespace BddDevelopmentSample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
