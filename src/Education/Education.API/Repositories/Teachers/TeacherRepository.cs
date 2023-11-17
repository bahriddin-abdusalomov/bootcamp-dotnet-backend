using Education.API.Data;
using Education.API.Models.Teachers;
using Microsoft.EntityFrameworkCore;

namespace Education.API.Repositories.Teachers;

public class TeacherRepository : ITeacherRepository
{
    private readonly AppDbContext _dbContext;

    public TeacherRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async ValueTask<long> CountAsync()
    {
        long count = await _dbContext.Teachers.CountAsync();
        return count;
    }

    public async ValueTask<int> CreateAsync(Teacher model)
    {
        await _dbContext.Teachers.AddAsync(model);
        int result = await _dbContext.SaveChangesAsync();
        return result;
    }

    public async ValueTask<int> DeleteAsync(Teacher model)
    {
        _dbContext.Teachers.Remove(model);
        int result = await _dbContext.SaveChangesAsync();
        return result;
    }

    public async ValueTask<IEnumerable<Teacher>> GetAllAsync()
    {
        IEnumerable<Teacher> teachers = _dbContext.Teachers;
        return teachers;
    }

    public async ValueTask<Teacher?> GetByIdAsync(long id)
    {
        Teacher? teacher = await _dbContext.Teachers.FirstOrDefaultAsync(x => x.Id == id);
        return teacher;

    }

    public async ValueTask<int> UpdateAsync(Teacher model)
    {
        _dbContext.Teachers.Update(model);
        int result = await _dbContext.SaveChangesAsync();
        return result;
    }
}
