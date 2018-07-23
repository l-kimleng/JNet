using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JNet.Startup))]
namespace JNet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
