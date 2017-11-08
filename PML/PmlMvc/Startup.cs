using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PmlMvc.Startup))]
namespace PmlMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
