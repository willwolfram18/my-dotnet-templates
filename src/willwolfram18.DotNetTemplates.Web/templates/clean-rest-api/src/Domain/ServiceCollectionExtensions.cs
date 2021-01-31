using $AppName$.Domain;
using $AppName$.Domain.Implementations;
using Microsoft.Extensions.DependencyInjection;

namespace $AppName$.Domain
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddWeatherServices(this IServiceCollection services)
        {
            return services.AddTransient<IWeatherService, WeatherService>();
        }
    }
}