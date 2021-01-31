using $AppName$.Domain.Abstractions;
using $AppName$.Infrastructure.Implementations;
using Microsoft.Extensions.DependencyInjection;

namespace $AppName$.Infrastructure
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddWeatherForecastRepository(this IServiceCollection services)
        {
            return services.AddTransient<IWeatherForecastRepository, RandomWeatherForecastRepository>();
        }
    }
}