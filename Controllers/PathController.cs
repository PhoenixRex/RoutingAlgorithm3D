using Microsoft.AspNetCore.Mvc;
using RoutingAlgorithm3D.Models.Box;
using RoutingAlgorithm3D.Models;

namespace RoutingAlgorithm3D.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PathController : ControllerBase
    {
        [HttpGet("test")]
        public IActionResult Test()
        {
            return Ok("Backend läuft! ✅");
        }

        [HttpPost("calculate")]
        public IActionResult Calculate([FromBody] PathRequest request)
        {
            var test = CreateBlock(false, false);
            return Ok(new { message = test });
        }

        private Box CreateBlock(bool box_A, bool box_B)
        {
            Box box = new Box();
            box.top      = false;
            box.bottom   = false;
            box.forward  = false;
            box.backward = false;
            box.left     = false;
            box.right    = false;
            box.point_A  = box_A;
            box.point_B  = box_B;
            box.X        = 0;
            box.Y        = 0;
            box.Z        = 0;
            box.rotation = Rotation.Deg0;
            return box;
        }
    }
}
