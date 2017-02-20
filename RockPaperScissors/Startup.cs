using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RockPaperScissors.Startup))]
namespace RockPaperScissors
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
