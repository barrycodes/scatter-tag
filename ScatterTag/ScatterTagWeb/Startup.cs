using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ScatterTagWeb.Startup))]
namespace ScatterTagWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
