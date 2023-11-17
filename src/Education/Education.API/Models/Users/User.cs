using Education.API.Models.Students;
using Education.API.Models.Teachers;
using System.ComponentModel.DataAnnotations;

namespace Education.API.Models.Users
{
    public class User
    {
        public long Id { get; set; }

        public string FirstName { get; set; }
        
        public string LastName { get; set; }
        
        public DateTime Birtday { get; set; }
        
        public string Email { get; set; }
        
        public string Password { get; set; }
        
        public string PhoneNumber { get; set; }

        public Student Student { get; set; }
     
        public Teacher Teacher { get; set; }

    }
}
