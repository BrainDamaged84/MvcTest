using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCTest2.Startup))]
namespace MVCTest2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
