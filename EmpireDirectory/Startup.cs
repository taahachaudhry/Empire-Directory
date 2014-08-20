using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EmpireDirectory.Startup))]
namespace EmpireDirectory
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
