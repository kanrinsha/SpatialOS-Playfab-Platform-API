using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SpatialPlayFabPlatformApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ValuesController : ControllerBase
    {
        private readonly ILogger<ValuesController> _logger;

        public ValuesController(ILogger<ValuesController> logger) => _logger = logger;

        [HttpGet]
        public string Get() => "ok";
    }
}
