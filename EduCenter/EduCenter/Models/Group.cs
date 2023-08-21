using System;
using System.Collections.Generic;

namespace EduCenter.Models;

public partial class Group
{
    public Guid GroupId { get; set; }

    public string Name { get; set; } = null!;

    public int Limit { get; set; }

    public virtual ICollection<GroupMember> GroupMembers { get; set; } = new List<GroupMember>();
}
