using Microsoft.AspNetCore.Mvc;
using sampleAPI.IServices.Auth;

namespace sampleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpGet]
        public IActionResult GenerateToken([FromQuery]int id,[FromServices] IAuthService _service)
        {
            var result =  _service.GenerateToken(id);
            if (result == null)
                return NoContent();
            return Ok(result);

        }
    }
}