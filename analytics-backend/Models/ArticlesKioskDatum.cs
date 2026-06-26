using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class ArticlesKioskDatum
{
    public int ArticleId { get; set; }

    public string? TileDescription { get; set; }

    public string? PageDescription { get; set; }

    public int? Max { get; set; }

    public int? Min { get; set; }

    public int? MediaId { get; set; }

    public int? TileMediaId { get; set; }

    public int? TileTemplateId { get; set; }

    public int? GroupByTagId { get; set; }

    public int? ArticlePageTileTemplateId { get; set; }

    public virtual Article Article { get; set; } = null!;

    public virtual KioskUiTileTemplate? ArticlePageTileTemplate { get; set; }

    public virtual ICollection<ArticlesKioskDataLang> ArticlesKioskDataLangs { get; set; } = new List<ArticlesKioskDataLang>();

    public virtual Tag? GroupByTag { get; set; }

    public virtual Medium? Media { get; set; }

    public virtual Medium? TileMedia { get; set; }

    public virtual KioskUiTileTemplate? TileTemplate { get; set; }
}
