using System;

namespace $AppName$.Domain.Models
{
    public class WeatherForecast
    {

#if (IsNetCore31)
        public WeatherForecast(DateTime date, int temperatureC, string? summary)
        {
            Date = date;
            TemperatureC = temperatureC;
            Summary = summary;
        }
#else
        public WeatherForecast(DateTime date, int temperatureC)
        {
            Date = date;
            TemperatureC = temperatureC;
        }
#endif

        public DateTime Date { get; }

        public int TemperatureC { get; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

#if (IsNetCore31)
        public string? Summary { get; }
#else
        public string? Summary { get; init; }
#endif
    }
}