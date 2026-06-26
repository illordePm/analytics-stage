using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class ArticlesKioskDataLang
{
    public int ArticleKioskDataId { get; set; }

    public string LanguageCode { get; set; } = null!;

    public string? PageDescription { get; set; }

    public string? TileDescription { get; set; }

    public int? TileMediaId { get; set; }

    public virtual ArticlesKioskDatum ArticleKioskData { get; set; } = null!;

    public virtual Medium? TileMedia { get; set; }
}
