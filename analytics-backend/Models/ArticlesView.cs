using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class ArticlesView
{
    public int? Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? PublicName { get; set; }

    public string? BillDescription { get; set; }

    public string? LongDescription { get; set; }

    public int? ArticleSubtype { get; set; }

    public decimal? ReferencePrice { get; set; }

    public string? TileDescription { get; set; }

    public string? PageDescription { get; set; }

    public int? Max { get; set; }

    public int? Min { get; set; }

    public int? MediaId { get; set; }

    public int? TileMediaId { get; set; }

    public int? TileTemplateId { get; set; }

    public int? ArticlePageTileTemplateId { get; set; }

    public int? GroupByTagId { get; set; }
}
