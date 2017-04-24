using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BMWMvp.Startup))]
namespace BMWMvp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
