using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Business_.Startup))]
namespace Business_
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
