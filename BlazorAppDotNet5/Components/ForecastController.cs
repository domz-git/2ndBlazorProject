using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorAppDotNet5.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace BlazorAppDotNet5.Components
{
    [Route("api/[controller]")]
    [ApiController]
    public class ForecastController:ControllerBase
    {
        public async Task<ActionResult<IEnumerable<WeatherForecast>>> GetActionResultAsync()
        {
            var svc = new WeatherForecastService();

            return new OkObjectResult(await svc.GetForecastAsync(DateTime.Now));
        }
    }
}
