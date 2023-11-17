using Education.API.Dtos.Students;
using Education.API.ViewModels.Students;

namespace Education.API.Services.Students;

public interface IStudentService
{
    public ValueTask<long> CountAsync();
    public ValueTask<bool> CreateAsync(StudentCreateDto dto);
    public ValueTask<bool> UpdateAsync(StudentUpdateDto dto);
    public ValueTask<bool> DeleteAsync(long id);
    public ValueTask<StudentViewModel> GetByIdAsync(long id);
    public ValueTask<IList<StudentViewModel>> GetAllAsync();
}
