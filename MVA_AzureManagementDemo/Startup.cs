using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVA_AzureManagementDemo.Startup))]
namespace MVA_AzureManagementDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
