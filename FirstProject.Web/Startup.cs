using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FirstProject.Web.Startup))]
namespace FirstProject.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
