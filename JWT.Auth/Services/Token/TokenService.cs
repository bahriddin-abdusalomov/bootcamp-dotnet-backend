using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace JWT.Auth.Services.Token
{
    public class TokenService : ITokenService
    {
        private readonly IConfiguration _configuration;

        public TokenService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string Generate(string username)
        {
            // bu malumotlar
            var claims = new Claim[]
            {
                // name 
                new Claim(JwtRegisteredClaimNames.Name, username),
                // identificatori
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                // vaqti
                new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),

            };

            // qandedur algoritm boyicha shifrlanadi
            var credentials = new SigningCredentials(
                new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"])),
                SecurityAlgorithms.HmacSha256
                );

            var token = new JwtSecurityToken(
                _configuration["JWT:ValidIssuer"],
                _configuration["JWT:ValidAu dience"],
                claims,
                expires: DateTime.UtcNow.AddDays(1),
                signingCredentials: credentials
                );

            var tokenHandler = new JwtSecurityTokenHandler();

            return tokenHandler.WriteToken(token);
        }
    }
}
