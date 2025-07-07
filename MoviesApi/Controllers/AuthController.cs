using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using MoviesApi.Application.Services;
using MoviesApi.Models;

namespace MoviesApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController(AccountService accountService) : ControllerBase
    {
        [HttpPost("register")]
        public IActionResult Register([FromBody] RegisterUserRequest request)
        {
            accountService.Register(request.UserName, request.FirstName, request.Password);
            return NoContent();
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            //accountService.Login(request.UserName, request.Password);
            return Ok();
        }
    }
}
