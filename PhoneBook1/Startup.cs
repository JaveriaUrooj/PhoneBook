using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PhoneBook1.Startup))]
namespace PhoneBook1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
