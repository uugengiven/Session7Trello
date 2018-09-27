using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Session7Trello.Startup))]
namespace Session7Trello
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
