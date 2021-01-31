using $AppName$.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace $AppName$.Domain
{
    public interface IWeatherService
    {
        Task<IEnumerable<WeatherForecast>> GetFiveDayForecastAsync();
    }
}