using Microsoft.Extensions.Logging.Abstractions;
using SimpleAPI.Controllers;
using System;
using Xunit;

namespace SimpleAPI.Test
{
	public class UnitTest1
	{

		WeatherForecastController controller = new WeatherForecastController(new NullLogger<WeatherForecastController>());

		[Fact]
		public void GetWeather()
		{
			var returnvalue = controller.GetSpecific(0);
			Assert.Equal("Freezing", returnvalue);
		}

		[Fact]
		public void Test1()
		{

		}
	}
}
