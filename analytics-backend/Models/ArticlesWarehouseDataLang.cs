using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class ArticlesWarehouseDataLang
{
    public int ArticleId { get; set; }

    public string LanguageCode { get; set; } = null!;

    public string? LongDescription { get; set; }

    public string? WarehouseName { get; set; }

    public virtual ArticlesWarehouseDatum Article { get; set; } = null!;
}
