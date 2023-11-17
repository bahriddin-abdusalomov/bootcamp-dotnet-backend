using Education.API.Models.Users;
using System.ComponentModel.DataAnnotations.Schema;

namespace Education.API.Models.Teachers
{
    public class Teacher
    {
        public long Id { get; set; }
        public string Speality { get; set; }
        public decimal Salary { get; set; }
        public long UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public User User { get; set; }
    }
}
