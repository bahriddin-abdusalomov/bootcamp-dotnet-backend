using System;
using System.Collections.Generic;

namespace EduCenter.Models;

public partial class Subject
{
    public string SubjectName { get; set; } = null!;

    public string Description { get; set; } = null!;

    public Guid SubjectId { get; set; }
}
