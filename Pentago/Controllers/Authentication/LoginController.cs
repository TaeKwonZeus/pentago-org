﻿using Microsoft.AspNetCore.Mvc;
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
    private readonly ILogger<LoginController> _logger;

    public LoginController(ILoginService loginService, ILogger<LoginController> logger)
    {
        _loginService = loginService;
        _logger = logger;
    }

    /// <summary>
    /// Verifies the user and sends an API key as a response.
    /// </summary>
    /// <param name="model">Request body.</param>
    /// <returns>The user's API key.</returns>
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] LoginModel model)
    {
        try
        {
            var res = await _loginService.LoginAsync(model);

            if (res != null)
            {
                _logger.LogInformation("Successfully logged in user {User}", model.UsernameOrEmail);
                return Ok(res);
            }

            return NotFound("User not found");
        }
        catch (Exception e)
        {
            _logger.LogWarning("Login failed", e);

            return Problem("Internal server error: ", e.Message);
        }
    }
}