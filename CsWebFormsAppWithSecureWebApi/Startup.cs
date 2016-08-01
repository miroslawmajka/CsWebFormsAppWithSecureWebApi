using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CsWebFormsAppWithSecureWebApi.Startup))]
namespace CsWebFormsAppWithSecureWebApi
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
