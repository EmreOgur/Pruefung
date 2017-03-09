using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Web.Http;

namespace Pruefung.Web.App_Start
{
    public static class WebApiConfig
    {
        public static void Configure(HttpConfiguration config)
        {
            RegisterRoutes(config);
            ConfigureSerializers(config);
        }

        public static void ConfigureSerializers(HttpConfiguration config)
        {
            var formatters = config.Formatters;
            var jsonFormatter = formatters.JsonFormatter;
            var settings = jsonFormatter.SerializerSettings;

            settings.Formatting = Formatting.Indented;
            settings.ContractResolver = new DefaultContractResolver();

            // Xml is not required
            formatters.Remove(formatters.XmlFormatter);
        }

        public static void RegisterRoutes(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}