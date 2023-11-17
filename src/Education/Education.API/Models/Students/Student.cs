using Education.API.Models.Users;
using System.ComponentModel.DataAnnotations.Schema;

namespace Education.API.Models.Students
{
    public class Student
    {
        public int Id { get; set; }
        public string Course { get; set; }  
        public string Group { get; set; }
        public long UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public User User { get; set; }

    }
}
