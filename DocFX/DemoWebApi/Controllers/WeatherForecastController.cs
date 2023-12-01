using Microsoft.AspNetCore.Mvc;

namespace DemoWebApi.Controllers
{
    /// <summary>
    ///     A controller for handling weather forecasts.
    /// </summary>

    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        /// <summary>
        ///     (Immutable) the summaries.
        /// </summary>

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        /// <summary>
        ///     (Immutable) the logger.
        /// </summary>

        private readonly ILogger<WeatherForecastController> _logger;

        /// <summary>
        ///     Initializes a new instance of the <see cref="WeatherForecastController"/> class.
        /// </summary>
        ///
        /// <param name="logger">   The logger. </param>

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        ///     (An Action that handles HTTP GET requests) enumerates the items in this collection that
        ///     meet given criteria.
        /// </summary>
        ///
        /// <returns>
        ///     An enumerator that allows foreach to be used to process the matched items.
        /// </returns>

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
