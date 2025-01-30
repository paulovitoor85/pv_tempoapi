using Microsoft.AspNetCore.Mvc;

namespace WeatherAPI.Controllers
{
    [ApiController]
    [Route("api/weather")]
    public class WeatherController : ControllerBase
    {
        private static readonly string[] DaysOfWeek = 
        { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

        private readonly Random _random = new();

        [HttpGet]
        public IActionResult GetWeather()
        {
            var weatherData = DaysOfWeek.Select(day => 
            {
                double celsius = _random.Next(-10, 40); // Temperatura aleatória entre -10 e 40°C
                return new
                {
                    Day = day,
                    TemperatureCelsius = celsius,
                    TemperatureFahrenheit = celsius * 9 / 5 + 32,
                    TemperatureKelvin = celsius + 273.15
                };
            });

            return Ok(weatherData);
        }
    }
}
