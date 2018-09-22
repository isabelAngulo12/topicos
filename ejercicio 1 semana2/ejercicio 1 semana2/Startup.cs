using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ejercicio_1_semana2.Startup))]
namespace ejercicio_1_semana2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
