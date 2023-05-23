using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyHome.Service;

namespace MyHome.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(string username, string password)
        {
            try
            {
                var tokenResponse = await _authService.Authenticate(username, password);

                if (tokenResponse == null)
                {
                    return Unauthorized();
                }

                return Ok(tokenResponse);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
       

    }
}
