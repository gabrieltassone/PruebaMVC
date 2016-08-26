using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Prueba_MVC_Music_Store.Startup))]
namespace Prueba_MVC_Music_Store
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
