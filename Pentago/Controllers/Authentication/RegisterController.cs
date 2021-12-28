using Microsoft.AspNetCore.Mvc;
using Pentago.Services.Authentication;
using Pentago.Services.Authentication.Models;

namespace Pentago.Controllers.Authentication;

/// <summary>
/// This controller represents a register endpoint.
/// </summary>
[Route("api/auth/[controller]")]
[ApiController]
public class RegisterController : ControllerBase
{
    private readonly IRegisterService _registerService;
    private readonly ILogger<RegisterController> _logger;

    public RegisterController(IRegisterService registerService, ILogger<RegisterController> logger)
    {
        _registerService = registerService;
        _logger = logger;
    }

    /// <summary>
    /// Registers the user.
    /// </summary>
    /// <param name="model">Request body.</param>
    [HttpPost]
    public async Task Post([FromBody] RegisterModel model)
    {
        try
        {
            await _registerService.RegisterAsync(model);
            _logger.LogInformation("User {User} logged in", model.Username);
        }
        catch (Exception e)
        {
            Response.StatusCode = 500;
            _logger.LogWarning("Login failed", e);
        }
    }
}
