using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MixProdotto.Startup))]
namespace MixProdotto
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
