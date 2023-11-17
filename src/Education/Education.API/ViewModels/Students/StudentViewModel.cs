using System.ComponentModel.DataAnnotations;

namespace Education.API.ViewModels.Students;

public class StudentViewModel
{
    public long Id { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public DateTime Birtday { get; set; }

    public string Email { get; set; }

    public string Password { get; set; }

    public string PhoneNumber { get; set; }
  
    public string Course { get; set; }
    
    public string Group { get; set; }
}
