using Pentago.Services.Authentication.Models;

namespace Pentago.Services.Authentication;

/// <summary>
/// This class is a default implementation of the <see cref="IAuthenticationService"/> interface.
/// </summary>
/// <inheritdoc cref="IAuthenticationService"/>
public class AuthenticationService : IAuthenticationService
{
    private readonly string _connectionString;

    public AuthenticationService(string connectionString)
    {
        _connectionString = connectionString;
    }

    public async Task<string?> LoginAsync(LoginModel model)
    {
        await Task.Run(() => { }).ConfigureAwait(false);

        throw new NotImplementedException();
    }

    public async Task RegisterAsync(RegisterModel model)
    {
        await Task.Run(() => { }).ConfigureAwait(false);

        throw new NotImplementedException();
    }
}