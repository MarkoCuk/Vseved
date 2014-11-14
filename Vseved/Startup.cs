using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vseved.Startup))]
namespace Vseved
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
