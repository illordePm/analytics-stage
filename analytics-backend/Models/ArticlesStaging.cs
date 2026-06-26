using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class ArticlesStaging
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public string? Name { get; set; }

    public string? PublicName { get; set; }

    public string? Description { get; set; }

    public string? LongDescription { get; set; }

    public string? BillDescription { get; set; }

    public string? VatCode { get; set; }

    public string? MeasUnitCode { get; set; }

    public int? ArticleType { get; set; }

    public int? ArticleSubtype { get; set; }

    public decimal? ReferencePrice { get; set; }

    public string? WarehouseLongDescription { get; set; }

    public decimal? WarehouseReferenceCost { get; set; }

    public int? ScalesPriceLookUp { get; set; }

    public decimal? Tare { get; set; }

    public decimal? Weight { get; set; }

    public string? WeightMeasUnitCode { get; set; }

    public bool? IsValid { get; set; }
}
