using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TutoLogin.Startup))]
namespace TutoLogin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
