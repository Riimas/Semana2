using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Semana2.Startup))]
namespace Semana2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
