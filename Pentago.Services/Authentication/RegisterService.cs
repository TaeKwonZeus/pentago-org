using Pentago.Services.Authentication.Models;

namespace Pentago.Services.Authentication;

/// <summary>
/// This class is a default implementation of the <see cref="IRegisterService"/> interface.
/// </summary>
/// <inheritdoc cref="IRegisterService"/>
public class RegisterService : IRegisterService
{
    private readonly string _connectionString;

    public RegisterService(string connectionString)
    {
        _connectionString = connectionString;
    }

    public async Task RegisterAsync(RegisterModel model)
    {
        await Task.Run(() => { }).ConfigureAwait(false);

        throw new NotImplementedException();
    }
}