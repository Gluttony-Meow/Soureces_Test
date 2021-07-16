using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Soureces_Test.Startup))]
namespace Soureces_Test
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
