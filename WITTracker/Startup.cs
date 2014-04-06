using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WITTracker.Startup))]
namespace WITTracker
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
