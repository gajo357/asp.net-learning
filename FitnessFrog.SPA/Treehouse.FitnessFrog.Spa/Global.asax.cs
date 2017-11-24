using System.Web;
using System.Web.Http;

namespace Treehouse.FitnessFrog.Spa
{
    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            // always at the top of Application_Start method
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
