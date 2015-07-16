using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(McvMovie.Startup))]
namespace McvMovie
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
