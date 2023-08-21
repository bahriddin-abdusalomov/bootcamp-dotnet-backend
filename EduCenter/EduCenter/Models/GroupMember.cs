using System;
using System.Collections.Generic;

namespace EduCenter.Models;

public partial class GroupMember
{
    public Guid GroupMemberId { get; set; }

    public Guid StudentId { get; set; }

    public Guid GroupId { get; set; }

    public virtual Group Group { get; set; } = null!;

    public virtual Student Student { get; set; } = null!;
}
