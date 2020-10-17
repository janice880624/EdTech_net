using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EdTech_game.Startup))]
namespace EdTech_game
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
