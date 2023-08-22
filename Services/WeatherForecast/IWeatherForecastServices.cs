using APIExample.Models;

namespace APIExample.Services.WeatherForecast
{
	public interface IWeatherForecastServices
	{
		public IEnumerable<WeatherForecastModel> List();
	}
}
