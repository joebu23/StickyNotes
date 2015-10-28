using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StickyNotes_Admin.Startup))]
namespace StickyNotes_Admin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
