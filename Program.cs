using APIExample.Services.WeatherForecast;
using Databases.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace APIExample
{
    public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.

			//setup SQL Server
			builder.Services.AddDbContext<ApplicationSqlServerContext>(options =>
			options.UseSqlServer(builder.Configuration.GetConnectionString("ApplicationContext")));

			//setup MySql
			var connectionString = builder.Configuration.GetConnectionString("ApplicationContextMySql");
			builder.Services.AddDbContext<ApplicationMySqlContext>(options =>
			options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));


			builder.Services.AddControllers();
			// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
			builder.Services.AddEndpointsApiExplorer();
			builder.Services.AddSwaggerGen();

			builder.Services.AddScoped<IWeatherForecastServices, WeatherForecastServices>();

			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (app.Environment.IsDevelopment())
			{
				app.UseSwagger();
				app.UseSwaggerUI();
			}

			app.UseHttpsRedirection();

			app.UseAuthorization();


			app.MapControllers();

			app.Run();
		}
	}
}