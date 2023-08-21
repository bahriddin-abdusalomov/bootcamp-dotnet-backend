using System;
using System.Collections.Generic;

namespace EduCenter.Models;

public partial class Teacher
{
    public Guid TeacherId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;
}
