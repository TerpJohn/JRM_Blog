using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JRM_Blog.Startup))]
namespace JRM_Blog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
