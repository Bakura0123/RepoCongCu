using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PhamKhacHuy.Startup))]
namespace PhamKhacHuy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
