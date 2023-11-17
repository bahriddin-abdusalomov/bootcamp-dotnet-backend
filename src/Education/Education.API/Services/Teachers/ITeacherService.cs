using Education.API.Dtos.Teachers;
using Education.API.ViewModels.Teachers;

namespace Education.API.Services.Teachers;

public interface ITeacherService
{
    public ValueTask<long> CountAsync();
    public ValueTask<bool> CreateAsync(TeacherCreateDto dto);
    public ValueTask<bool> UpdateAsync(TeacherUpdateDto dto);
    public ValueTask<bool> DeleteAsync(long id);
    public ValueTask<TeacherViewModel> GetByIdAsync(long id);
    public ValueTask<IList<TeacherViewModel>> GetAllAsync();
}
