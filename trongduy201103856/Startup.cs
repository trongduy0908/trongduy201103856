using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(trongduy201103856.Startup))]
namespace trongduy201103856
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
