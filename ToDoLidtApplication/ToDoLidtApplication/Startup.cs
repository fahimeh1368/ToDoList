using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ToDoLidtApplication.Startup))]
namespace ToDoLidtApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
