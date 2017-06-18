using Newtonsoft.Json;
using System;
using System.Web.Http;
using System.Web.Http.SelfHost;

namespace ServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = GetSelfHostConfiguration();

            StartSelfHost(config);
        }

        private static HttpSelfHostConfiguration GetSelfHostConfiguration()
        {
            var _baseAddress = new Uri("http://localhost:8080/");

            var config = new HttpSelfHostConfiguration(_baseAddress);

            // Attribute routing.
            config.MapHttpAttributeRoutes();

            // Configure method parameters serialization type
            config.Formatters.JsonFormatter.SerializerSettings = new JsonSerializerSettings();

            return config;
        }

        private static void StartSelfHost(HttpSelfHostConfiguration config)
        {
            var server = new HttpSelfHostServer(config);

            // Start listening
            server.OpenAsync().Wait();

            Console.WriteLine("CSPOS Web API Self-host running at " + config.BaseAddress);
            Console.WriteLine("Hit ENTER to exit...");
            Console.ReadLine();

            server.CloseAsync().Wait();
        }
    }
}
