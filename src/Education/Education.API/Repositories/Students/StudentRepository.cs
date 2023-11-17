using Education.API.Data;
using Education.API.Models.Students;
using Microsoft.EntityFrameworkCore;

namespace Education.API.Repositories.Students;

public class StudentRepository : IStudentRepository
{
    private readonly AppDbContext _dbContext;

    public StudentRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async ValueTask<long> CountAsync()
    {
        long count = await _dbContext.Students.CountAsync();
        return count;
    }

    public async ValueTask<int> CreateAsync(Student model)
    {
        await _dbContext.Students.AddAsync(model);
        int result = await _dbContext.SaveChangesAsync();
        return result;
    }

    public async ValueTask<int> DeleteAsync(Student model)
    {
        _dbContext.Students.Remove(model);
        int result = await _dbContext.SaveChangesAsync();
        return result;
    }

    public async ValueTask<IEnumerable<Student>> GetAllAsync()
    {
        IEnumerable<Student> Students = _dbContext.Students;
        return Students;
    }

    public async ValueTask<Student?> GetByIdAsync(long id)
    {
        Student? Student = await _dbContext.Students.FirstOrDefaultAsync(x => x.Id == id);
        return Student;

    }

    public async ValueTask<int> UpdateAsync(Student model)
    {
        _dbContext.Students.Update(model);
        int result = await _dbContext.SaveChangesAsync();
        return result;
    }
}
