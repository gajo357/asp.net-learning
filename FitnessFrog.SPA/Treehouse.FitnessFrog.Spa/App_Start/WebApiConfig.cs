using Newtonsoft.Json.Serialization;
using System.Web.Http;

namespace Treehouse.FitnessFrog.Spa
{
    public static class WebApiConfig
    {
        public const string DefaultApiName = "DefaultApi";
        public static void Register(HttpConfiguration config)
        {
            var jsonSeriealizerSettings = config.Formatters.JsonFormatter.SerializerSettings;
            jsonSeriealizerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            jsonSeriealizerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

            config.Routes.MapHttpRoute(
                name: DefaultApiName,
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional });
        }
    }
}