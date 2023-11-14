namespace JWT.Auth.Services.Token;

public interface ITokenService
{
    string Generate(string username);
}
