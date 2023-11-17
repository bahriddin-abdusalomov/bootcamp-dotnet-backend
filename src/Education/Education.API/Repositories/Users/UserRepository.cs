using Education.API.Data;
using Education.API.Models.Users;
using Microsoft.EntityFrameworkCore;

namespace Education.API.Repositories.Users;

public class UserRepository : IUserRepository
{
    private readonly AppDbContext _dbContext;

    public UserRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async ValueTask<long> CountAsync()
    {
        long count = await _dbContext.Users.CountAsync();
        return count;
    }

    public async ValueTask<int> CreateAsync(User model)
    {
        await _dbContext.Users.AddAsync(model);
        int result = await _dbContext.SaveChangesAsync();
        return result;
    }

    public async ValueTask<int> DeleteAsync(User model)
    {
        _dbContext.Users.Remove(model);
        int result = await _dbContext.SaveChangesAsync();
        return result;
    }

    public async ValueTask<IEnumerable<User>> GetAllAsync()
    {
        IEnumerable<User> Users = _dbContext.Users;
        return Users;
    }

    public async ValueTask<User?> GetByIdAsync(long id)
    {
        User? User = await _dbContext.Users.FirstOrDefaultAsync(x => x.Id == id);
        return User;

    }

    public async ValueTask<int> UpdateAsync(User model)
    {
        _dbContext.Users.Update(model);
        int result = await _dbContext.SaveChangesAsync();
        return result;
    }
}
