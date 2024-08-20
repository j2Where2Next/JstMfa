using JwtMfaExample.Services;
using Microsoft.AspNetCore.Mvc;

namespace JwtMfaExample.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserService _userService;

        public AuthController(UserService userService)
        {
            _userService = userService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(string username, string password)
        {
            var user = await _userService.Authenticate(username, password);

            if (user == null)
                return Unauthorized();

            // Generate JWT token
            // Return token to the client
            return Ok(new { Token = "dummy_jwt_token" });
        }
    }
}