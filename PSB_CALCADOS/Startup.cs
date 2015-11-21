using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PSB_CALCADOS.Startup))]
namespace PSB_CALCADOS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
