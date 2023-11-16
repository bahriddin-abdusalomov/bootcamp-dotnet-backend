using JWT.Auth.Data;
using JWT.Auth.Dtos;
using JWT.Auth.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JWT.Auth.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly AppDbContext _dbContext;

        public UsersController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost]
        public async ValueTask<IActionResult> CreateUserAsync(UserDto userDto)
        {
            User user = new User();
            user.UserName = userDto.UserName;
            user.Password = userDto.Password;

            await _dbContext.Users.AddAsync(user);
            int result = await _dbContext.SaveChangesAsync();
            return Ok(result > 0);
        }

        [Authorize]
        [HttpGet(Name = "Users")]
        public async ValueTask<IActionResult> GetAllUserAsync()
        {
            var users = await _dbContext.Users.ToListAsync();
            return Ok(users);
        }
    }
}
