using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SocialLifeTracker.Startup))]
namespace SocialLifeTracker
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
