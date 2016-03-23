using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebUserAuth.Startup))]
namespace WebUserAuth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
