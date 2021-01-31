using System.Collections.Generic;
using System.Threading.Tasks;

namespace $AppName$.Domain.Abstractions
{
    public interface IWeatherForecastRepository
    {
        Task<IEnumerable<WeatherForecast>> GetWeatherForecastAsync(int numDays);
    }
}