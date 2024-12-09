using Microsoft.AspNetCore.Mvc;

namespace AI_Game.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GameController : ControllerBase
    {
        [HttpGet("status")]
        public IActionResult GetStatus()
        {
            return Ok(new { Status = "Game is running" });
        }
    }
}
