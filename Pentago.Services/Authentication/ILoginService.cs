using Pentago.Services.Authentication.Models;

namespace Pentago.Services.Authentication;

public interface ILoginService {
    string Login(LoginModel model);
}