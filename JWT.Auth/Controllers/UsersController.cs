using JWT.Auth.Data;
using JWT.Auth.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
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

        [Authorize]
        [HttpGet(Name = "Users")]
        public async ValueTask<IActionResult> GetAllUserAsync(UserDto userDto)
        {
            var users = await _dbContext.Users.ToListAsync();
            return Ok(users);
        }
    }
}
