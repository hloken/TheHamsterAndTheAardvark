using Microsoft.AspNetCore.Mvc;

namespace PlanetEscape.Api.Health
{
    [ApiController]
    [Route("api/health")]
    public class HealthController : ControllerBase
    {
        [HttpGet]
        public CheckHealthResponse CheckHealth()
        {
            return new CheckHealthResponse();
        }
    }

    public class CheckHealthResponse
    {
    }
}