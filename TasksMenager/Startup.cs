using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TasksMenager.Startup))]
namespace TasksMenager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
