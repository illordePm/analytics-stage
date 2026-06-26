using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class ArticlesLink
{
    public int ParentId { get; set; }

    public int ChildId { get; set; }

    public int? MinQuantity { get; set; }

    public int? MaxQuantity { get; set; }

    public int? SortOrder { get; set; }

    public virtual Article Child { get; set; } = null!;

    public virtual Article Parent { get; set; } = null!;
}
