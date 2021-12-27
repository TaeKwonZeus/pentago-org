using Pentago.Services.Authentication.Models;

namespace Pentago.Services.Authentication;

/// <summary>
/// This interface represents a register service.
/// </summary>
public interface IRegisterService
{
    /// <summary>
    /// Registers the user.
    /// </summary>
    /// <param name="model">User data.</param>
    Task RegisterAsync(RegisterModel model);
}