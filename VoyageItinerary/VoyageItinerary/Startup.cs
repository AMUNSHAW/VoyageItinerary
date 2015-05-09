using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VoyageItinerary.Startup))]
namespace VoyageItinerary
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
