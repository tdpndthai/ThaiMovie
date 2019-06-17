using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ThaiMovie.Startup))]
namespace ThaiMovie
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
