using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HttpEchoRequest.Startup))]
namespace HttpEchoRequest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
