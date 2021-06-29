using ConfigServerClient.Configs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigServerClient.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        private readonly IOptions<WeatherConfig> _weatherConfigOpts;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IOptions<WeatherConfig> weatherConfigOpts)
        {
            _logger = logger;
            _weatherConfigOpts = weatherConfigOpts;
        }

        [HttpGet]
        public WeatherConfig Get()
        {
            return _weatherConfigOpts.Value;
        }
    }
}
