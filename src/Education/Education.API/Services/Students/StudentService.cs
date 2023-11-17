using Education.API.Dtos.Students;
using Education.API.Models.Students;
using Education.API.Models.Users;
using Education.API.Repositories.Students;
using Education.API.Repositories.Users;
using Education.API.ViewModels.Students;

namespace Education.API.Services.Students
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IUserRepository _userRepository;

        public StudentService(
            IStudentRepository studentRepository,
            IUserRepository userRepository)
        {
            _studentRepository = studentRepository;
            _userRepository = userRepository;
        }

        public async ValueTask<long> CountAsync()
        {
            long count = await _studentRepository.CountAsync();
            return count;
        }

        public async ValueTask<bool> CreateAsync(StudentCreateDto dto)
        {
            User user = new User()
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Email = dto.Email,
                Password = dto.Password,
                PhoneNumber = dto.PhoneNumber,
                Birtday = dto.Birtday
            };

            int resultUser = await _userRepository.CreateAsync(user);

            Student student = new Student()
            {
                Course = dto.Course,
                Group = dto.Group,
                UserId = user.Id
            };

            int resultStudent = await _studentRepository.CreateAsync(student);

            return resultStudent > 0 && resultUser > 0;
        }

        public async ValueTask<bool> DeleteAsync(long id)
        {
            Student student = await _studentRepository.GetByIdAsync(id);
            if (student is null) throw new FileNotFoundException();
            int resultStudnet = await _studentRepository.DeleteAsync(student);

            return resultStudnet > 0;
        }

        public async ValueTask<IList<StudentViewModel>> GetAllAsync()
        {
            var students = (await _studentRepository.GetAllAsync()).ToList();
            var users = (await _userRepository.GetAllAsync()).ToList();

            var joinedData = students.Join(users,
                student => student.UserId,
                user => user.Id,
                (student, user) => new StudentViewModel
                {
                    Id  = student.Id,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Birtday = user.Birtday,
                    PhoneNumber = user.PhoneNumber,
                    Email = user.Email,
                    Password = user.Password,
                    Course = student.Course,
                    Group = student.Group,
                }).ToList();

            return joinedData;
        }

        public async ValueTask<StudentViewModel> GetByIdAsync(long id)
        {
            Student student = await _studentRepository.GetByIdAsync(id);
            if(student is null) throw new FileNotFoundException();

            User user  =await _userRepository.GetByIdAsync(student.UserId);
            if(user is null) throw new FileNotFoundException();

            var studentView = new StudentViewModel
            {
                Id = student.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Birtday = user.Birtday,
                PhoneNumber = user.PhoneNumber,
                Email = user.Email,
                Password = user.Password,
                Course = student.Course,
                Group = student.Group,
            };

            return studentView;
        }

        public async ValueTask<bool> UpdateAsync(StudentUpdateDto dto)
        {
            var student = await _studentRepository.GetByIdAsync(dto.Id);
            if(student is null) throw new FileNotFoundException();

            student.Course = dto.Course;
            student.Group = dto.Group;

            var user = await _userRepository.GetByIdAsync(student.UserId);

            user.FirstName = dto.FirstName;
            user.LastName = dto.LastName;
            user.Birtday = dto.Birtday;
            user.PhoneNumber = dto.PhoneNumber;
            user.Email = dto.Email;
            user.Password = dto.Password;

            int resultStudent = await _studentRepository.UpdateAsync(student);
            int resultUser = await _userRepository.UpdateAsync(user);

            return resultStudent > 0 && resultUser > 0;
        }
    }
}
