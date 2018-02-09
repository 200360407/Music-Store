using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Web2018.Startup))]
namespace Web2018
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
