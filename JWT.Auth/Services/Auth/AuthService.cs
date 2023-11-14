using JWT.Auth.Data;
using JWT.Auth.Dtos;
using JWT.Auth.Services.Token;
using Microsoft.EntityFrameworkCore;

namespace JWT.Auth.Services.Auth;

public class AuthService : IAuthService
{
    private readonly AppDbContext _dbContext;
    private readonly ITokenService _tokenSerice;

    public AuthService(AppDbContext applicationDbContext, ITokenService tokenService)
    {
        _dbContext = applicationDbContext;
        _tokenSerice = tokenService;
    }

    public async ValueTask<string> Login(UserDto request)
    {
        var user = await _dbContext.Users.FirstOrDefaultAsync(x => x.UserName == request.UserName);

        if (user == null)
        {
            throw new Exception("User Not Found");
        }
        else if (user.Password != request.Password)
        {
            throw new Exception("Password is wrong");
        }

        return _tokenSerice.Generate(user.UserName);
    }
}