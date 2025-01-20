using Microsoft.AspNetCore.Mvc;
using TechExam.Services;
using TechExam.Models;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly JwtTokenService _jwtTokenService;

    public AuthController(JwtTokenService jwtTokenService)
    {
        _jwtTokenService = jwtTokenService;
    }

    [HttpPost("getToken")]
    public IActionResult Login([FromBody] LoginRequest loginRequest)
    {
        if (loginRequest.Username == "testuser" && loginRequest.Password == "password")
        {
            var token = _jwtTokenService.GenerateToken(loginRequest.Username);
            return Ok(new { token });
        }
        return Unauthorized();
    }
}
