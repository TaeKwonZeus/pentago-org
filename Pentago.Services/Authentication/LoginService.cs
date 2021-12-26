using Pentago.Services.Authentication.Models;

namespace Pentago.Services.Authentication;

public class LoginService : ILoginService
{
    private readonly string _connectionString;

    public LoginService(string connectionString)
    {
        _connectionString = connectionString;
    }

    public string Login(LoginModel model)
    {
        throw new NotImplementedException();
    }
}