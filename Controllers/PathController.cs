using Microsoft.AspNetCore.Mvc;
using RoutingAlgorithm3D.Models.Box;
using RoutingAlgorithm3D.Services;

namespace RoutingAlgorithm3D.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PathController : ControllerBase
    {
        [HttpGet("test")]
        public IActionResult Test()
        {
            return Ok("it is Working");
        }

        [HttpPost("calculate")]
        public IActionResult Calculate([FromBody] Boxes request)
        {
            var service = new PathfindingService(request);
            var path = service.Calculate();
            return Ok(new { message = $"{path}" });
        }
    }
}