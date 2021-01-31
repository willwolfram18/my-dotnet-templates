using System.Collections.Generic;
using System.Threading.Tasks;

namespace $AppName$.Domain
{
    interface IWeatherService
    {
        Task<IEnumerable<WeatherForecast>> GetFiveDayForecastAsync();
    }
}