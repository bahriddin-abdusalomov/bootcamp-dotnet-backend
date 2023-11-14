using JWT.Auth.Dtos;

namespace JWT.Auth.Services.Auth
{
    public interface IAuthService
    {
        ValueTask<string> Login(UserDto request);
    }
}
