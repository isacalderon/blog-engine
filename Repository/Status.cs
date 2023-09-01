using System;
using System.Collections.Generic;

namespace blog_engine.Repository;

public partial class Status
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<PostStatus> PostStatuses { get; set; } = new List<PostStatus>();
}
