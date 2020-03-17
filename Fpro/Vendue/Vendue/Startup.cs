using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vendue.Startup))]
namespace Vendue
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
