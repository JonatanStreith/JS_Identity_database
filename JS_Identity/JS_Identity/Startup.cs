using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JS_Identity_Project.Startup))]
namespace JS_Identity_Project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
