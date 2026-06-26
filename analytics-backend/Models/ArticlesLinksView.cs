using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class ArticlesLinksView
{
    public int? ParentId { get; set; }

    public int? ChildId { get; set; }

    public int? MinQuantity { get; set; }

    public int? MaxQuantity { get; set; }

    public int? SortOrder { get; set; }
}
