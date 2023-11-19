using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BasicMVCProject.Startup))]
namespace BasicMVCProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
