using Microsoft.Extensions.DependencyInjection;
using TinyUrlShortenerServiceApp.Interfaces;
using TinyUrlShortenerServiceApp.Services;

namespace TinyUrlShortenerServiceApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var services = ConfigureServices();
            
            var serviceProvider = services.BuildServiceProvider();

            serviceProvider.GetService<TinyUrlShortenerApp>().Run(args);
        }

        private static IServiceCollection ConfigureServices()
        {
            var services = new ServiceCollection();
            services.AddTransient<IUrlShortenerService, UrlShortenerService>();
            services.AddTransient<TinyUrlShortenerApp>();

            return services;
        }
    }
}
