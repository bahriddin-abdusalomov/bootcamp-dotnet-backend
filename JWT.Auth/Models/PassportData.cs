using JWT.Auth.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace JWT.Auth.Models;

public class PassportData
{
    public long PassportDataId { get; set; }
    public string FistName { get; set; }
    public string LastName { get; set; }
    public Gender Gender { get; set; }
    public DateTime Birthday { get; set; }
    public string PassportNumber { get; set; }
    public long UserId { get; set; }

    [ForeignKey("UserId")]
    public User User { get; set; } 
}
