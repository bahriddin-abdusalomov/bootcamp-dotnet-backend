using Education.API.Dtos.Students;
using Education.API.Models.Students;
using Education.API.Services.Students;
using Education.API.ViewModels.Students;
using Microsoft.AspNetCore.Mvc;

namespace Education.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public async ValueTask<IActionResult> CountStudentAsync()
        {
            long count = await _studentService.CountAsync();
            return Ok(count);
        }

        [HttpPost]
        public async ValueTask<IActionResult> CreateStudentAsync(StudentCreateDto student)
        {
            bool result = await _studentService.CreateAsync(student);
            return Ok(result);
        }

        [HttpGet]
        public async ValueTask<IActionResult> GetStudentAsync(long id)
        {
            StudentViewModel student = await _studentService.GetByIdAsync(id);
            return Ok(student);
        }

        [HttpGet]
        public async ValueTask<IActionResult> GetAllStudentAsync()
        {
            IList<StudentViewModel> students = await _studentService.GetAllAsync();
            return Ok(students);
        }

        [HttpDelete]
        public async ValueTask<IActionResult> DeleteStudentAsync(long id)
        {
            bool result = await _studentService.DeleteAsync(id);
            return Ok(result);
        }

        [HttpPut]
        public async ValueTask<IActionResult> UpdateStudentAsync(StudentUpdateDto student)
        {
            bool result = await _studentService.UpdateAsync(student);
            return Ok(result);
        }
    }
}
 