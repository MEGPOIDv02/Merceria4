using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Merceria4.Startup))]
namespace Merceria4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
