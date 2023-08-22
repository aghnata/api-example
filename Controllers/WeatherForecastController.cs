using APIExample.Models;
using APIExample.Services.WeatherForecast;
using Microsoft.AspNetCore.Mvc;

namespace APIExample.Controllers
{
    [ApiController]
	[Route("[controller]")]
	public class WeatherForecastController : ControllerBase
	{
		private readonly IWeatherForecastServices _service;
		public WeatherForecastController(
			IWeatherForecastServices service
			) 
		{
			_service = service;
		}

		[HttpGet(Name = "GetWeatherForecast")]
		public IEnumerable<WeatherForecastModel> Get()
		{
			return _service.List();
		}
	}
}