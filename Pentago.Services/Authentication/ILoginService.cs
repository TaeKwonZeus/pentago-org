using Pentago.Services.Authentication.Models;

namespace Pentago.Services.Authentication;

/// <summary>
/// This interface represents a login service.
/// </summary>
public interface ILoginService
{
    /// <summary>
    /// Verifies the user and creates an API key.
    /// </summary>
    /// <param name="model">User data.</param>
    /// <returns>The user's API key.</returns>
    Task<string?> LoginAsync(LoginModel model);
}