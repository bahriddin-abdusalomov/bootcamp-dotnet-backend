using System.ComponentModel.DataAnnotations.Schema;

namespace JWT.Auth.Models;

public class Car
{
    public long CarId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public long UserId { get; set; }

    [ForeignKey("UserId")]
    public User User { get; set; }
}