using Education.API.Models.Students;
using Education.API.Models.Teachers;
using System.ComponentModel.DataAnnotations;

namespace Education.API.ViewModels.Teachers;

public class TeacherViewModel
{

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public DateTime Birtday { get; set; }

    public string Email { get; set; }

    public string Password { get; set; }

    public string PhoneNumber { get; set; }

    public string Speality { get; set; }
    
    public decimal Salary { get; set; }
}
