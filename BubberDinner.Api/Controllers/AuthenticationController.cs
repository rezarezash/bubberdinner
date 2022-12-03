using BubberDinner.Application.Services.Authentication;
using BubberDinner.Contracts.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace BubberDinner.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class AuthenticationController : ControllerBase
{
    private readonly IAuthService _authenticationService;

    public AuthenticationController(IAuthService authenticationService)
    {
        _authenticationService = authenticationService;
    }

    [HttpPost("register")]
    public IActionResult Register(RegisterRequest registerRequest)
    {
        var authResult = _authenticationService.Register(
            registerRequest.FirstName,
            registerRequest.LastName,
            registerRequest.Email,
            registerRequest.Password);
        var authResponse = new AuthenticationResponse(authResult.Id, authResult.FirstName, authResult.LastName,
            authResult.Email, authResult.Token);
        return Ok(authResponse);
    }

    [HttpPost("login")]
    public IActionResult Login(LoginRequest loginRequest)
    {
        var loginResult = _authenticationService.Login(loginRequest.Email, loginRequest.Password);
        var loginResponse = new AuthenticationResponse(loginResult.Id, loginResult.FirstName, loginResult.LastName,
            loginResult.Email,
            loginResult.Token);
        
        return Ok(loginResponse);
    }
}