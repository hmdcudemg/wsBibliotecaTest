using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(wsBibliotecaTest.Startup))]
namespace wsBibliotecaTest
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
