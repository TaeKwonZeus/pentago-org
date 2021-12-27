using Microsoft.AspNetCore.Mvc;
using Pentago.Services.Authentication;
using Pentago.Services.Authentication.Models;

namespace Pentago.Controllers.Authentication;

/// <summary>
/// This controller represents a login endpoint.
/// </summary>
[Route("api/auth/[controller]")]
[ApiController]
public class LoginController : ControllerBase
{
    private readonly ILoginService _loginService;

    public LoginController(ILoginService loginService)
    {
        _loginService = loginService;
    }

    /// <summary>
    /// Verifies the user and sends an API key as a response.
    /// </summary>
    /// <param name="model">The request body.</param>
    /// <returns>The user's API key.</returns>
    [HttpPost]
    public async Task<string> Post([FromBody] LoginModel model)
    {
        var res = await _loginService.LoginAsync(model);

        if (res != null) return res;

        Response.StatusCode = 404;
        return "User not found";
    }
}