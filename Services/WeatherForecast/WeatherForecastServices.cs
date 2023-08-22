using APIExample.Controllers;
using APIExample.Models;

namespace APIExample.Services.WeatherForecast
{
	public class WeatherForecastServices : IWeatherForecastServices
	{
		private static readonly string[] Summaries = new[]
		{
		"Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
		};

		private readonly ILogger<WeatherForecastController> _logger;

		public WeatherForecastServices(ILogger<WeatherForecastController> logger)
		{
			_logger = logger;
		}

		public IEnumerable<WeatherForecastModel> List() 
		{
			_logger.LogInformation("mulai memanggil API");

			_logger.LogInformation("asasa");
			_logger.LogDebug("ini debug");
			_logger.LogError("Ini errror");

			return Enumerable.Range(1, 3).Select(index => new WeatherForecastModel
			{
				Date = DateTime.Now.AddDays(index),
				TemperatureC = Random.Shared.Next(-20, 55),
				Summary = Summaries[Random.Shared.Next(Summaries.Length)]
			})
			.ToArray();
		}



	}
}
