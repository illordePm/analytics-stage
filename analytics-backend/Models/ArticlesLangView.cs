using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class ArticlesLangView
{
    public int? ArticleId { get; set; }

    public string? LanguageCode { get; set; }

    public string? PublicName { get; set; }

    public string? Description { get; set; }

    public string? LongDescription { get; set; }

    public string? BillDescription { get; set; }

    public string? PageDescription { get; set; }

    public string? TileDescription { get; set; }

    public int? TileMediaId { get; set; }

    public string? Ingredients { get; set; }
}
