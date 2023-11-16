using System.ComponentModel.DataAnnotations.Schema;

namespace JWT.Auth.Models;

public class User
{
    public long UserId { get; set; }
    public string UserName { get; set;}
    public string Password { get; set;}
    public string Role { get; set; } 
    public long PassportDataId { get; set; }

    [ForeignKey("PassportDataId")]
    public PassportData PassportData { get; set; }

    public ICollection<Car> Cars { get; set; }
}
