using Microsoft.AspNetCore.Mvc;

namespace BookingRoomBackend.Controllers
{
    [ApiController]
    public class LoginInController : ControllerBase
    {
        [HttpGet("login")]
        public async Task<IActionResult> GetLoginIn(string userName, string password)
        {
            if (userName == "admin" && password == "admin") 
            {
                return this.Ok();
            }
            return NotFound();
        }
    }
}
