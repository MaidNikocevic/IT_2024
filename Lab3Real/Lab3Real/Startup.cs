using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab3Real.Startup))]
namespace Lab3Real
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
