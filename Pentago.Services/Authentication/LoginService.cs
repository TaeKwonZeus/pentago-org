using Pentago.Services.Authentication.Models;

namespace Pentago.Services.Authentication;

/// <summary>
/// This class provides a default implementation of the <see cref="ILoginService"/> interface.
/// </summary>
/// <inheritdoc cref="ILoginService"/>
public class LoginService : ILoginService
{
    private readonly string _connectionString;

    public LoginService(string connectionString)
    {
        _connectionString = connectionString;
    }

    public string? Login(LoginModel model)
    {
        throw new NotImplementedException();
    }
}