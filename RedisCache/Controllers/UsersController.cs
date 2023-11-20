using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using RedisCache.Models;
using System;
using System.Text;
using System.Threading.Tasks;

[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    private readonly IDistributedCache _distributedCache;

    public UsersController(IDistributedCache distributedCache)
    {
        _distributedCache = distributedCache;
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] User user)
    {
        if (user == null)
        {
            return BadRequest("Invalid user data");
        }

        var key = $"user:{Guid.NewGuid()}";
        var encodedUser = Encoding.UTF8.GetBytes(Newtonsoft.Json.JsonConvert.SerializeObject(user));

        var options = new DistributedCacheEntryOptions
        {
            AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(10),
            SlidingExpiration = TimeSpan.FromMinutes(2)
        };

        await _distributedCache.SetAsync(key, encodedUser, options);

        return CreatedAtAction(nameof(Get), new { key }, user);
    }

    [HttpGet("{key}")]
    public async Task<IActionResult> Get(string key)
    {
        var cachedUser = await _distributedCache.GetAsync(key);

        if (cachedUser != null)
        {
            var userJson = Encoding.UTF8.GetString(cachedUser);
            var user = Newtonsoft.Json.JsonConvert.DeserializeObject<User>(userJson);
            return Ok(user);
        }
        else
        {
            return NotFound("User not found");
        }
    }
}
