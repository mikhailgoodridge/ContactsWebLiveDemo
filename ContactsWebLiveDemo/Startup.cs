using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ContactsWebLiveDemo.Startup))]
namespace ContactsWebLiveDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
