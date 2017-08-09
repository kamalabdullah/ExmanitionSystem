using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Examinition.Web.Core.Startup))]
namespace Examinition.Web.Core
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
