using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherApiInterface.Data
{
	public class WeatherQueryDto
	{
		public string City { get; set; }
		public string ApiKey { get; set; }
	}
}
