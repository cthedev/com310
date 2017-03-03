using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(COM_Project.Startup))]
namespace COM_Project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
