using Microsoft.Owin;
using MediaCatalog;
using Owin;

[assembly: OwinStartup(typeof (Startup))]

namespace MediaCatalog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}