using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AdminLTE_Application.Startup))]
namespace AdminLTE_Application
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
