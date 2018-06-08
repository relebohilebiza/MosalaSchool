using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MosalaSchool.Startup))]
namespace MosalaSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
