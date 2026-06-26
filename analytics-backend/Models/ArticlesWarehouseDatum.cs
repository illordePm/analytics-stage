using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class ArticlesWarehouseDatum
{
    public int ArticleId { get; set; }

    public string? LongDescription { get; set; }

    public decimal ReferenceCost { get; set; }

    public string? WarehouseName { get; set; }

    public virtual Article Article { get; set; } = null!;

    public virtual ICollection<ArticlesWarehouseDataLang> ArticlesWarehouseDataLangs { get; set; } = new List<ArticlesWarehouseDataLang>();
}
