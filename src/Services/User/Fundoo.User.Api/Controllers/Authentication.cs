using Fundoo.User.Api.Contracts;
using Fundoo.User.Application.Services;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;

namespace Fundoo.User.Api.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class Authentication : ControllerBase
    {
        UserService _service;
        public Authentication(UserService service)
        {
            _service = service;
        }

        [Route("register")]
        [HttpPost]
        public async Task<IActionResult> Register([FromBody] UserRegisterRequest registerRequest)
        {
            await _service.RegisterUser(
                registerRequest.FirstName, 
                registerRequest.LastName, 
                registerRequest.Email,
                registerRequest.Password);
            return Ok("User registered successfully!");
        }

        [Route("login")]
        [HttpPost]
        public async Task<IActionResult> Login([FromBody] UserLoginRequest loginRequest)
        {
           var result = await _service.LoginUser(
                loginRequest.Email,
                loginRequest.Password);

            if(result)
            {
                return Ok("Valid User login!");
            } else
            {
                return BadRequest("Invalid User login");
            }
        }
        
    }
}
