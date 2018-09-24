using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CallOut.Startup))]
namespace CallOut
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
