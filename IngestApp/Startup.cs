using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IngestApp.Startup))]
namespace IngestApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
