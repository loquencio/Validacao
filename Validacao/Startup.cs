using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Validacao.Startup))]
namespace Validacao
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
