using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class PurchasePriceListDetail
{
    public int Id { get; set; }

    public int PurchasePriceListId { get; set; }

    public int ArticleId { get; set; }

    public int MeasUnitId { get; set; }

    public decimal ConversionFactor { get; set; }

    public decimal NetCost { get; set; }

    public string SupplierArticleCode { get; set; } = null!;

    public string? SupplierDescription { get; set; }

    public decimal? DiscountA { get; set; }

    public decimal? DiscountB { get; set; }

    public decimal? DiscountC { get; set; }

    public decimal? DiscountD { get; set; }

    public decimal? DiscountE { get; set; }

    public int? OrderMeasUnitId { get; set; }

    public decimal? OrderConversionFactor { get; set; }

    public DateOnly? ValidityFrom { get; set; }

    public DateOnly? ValidityTo { get; set; }

    public bool IsValid { get; set; }

    public string? Notes { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public virtual Article Article { get; set; } = null!;

    public virtual MeasUnit MeasUnit { get; set; } = null!;

    public virtual MeasUnit? OrderMeasUnit { get; set; }

    public virtual PurchasePriceList PurchasePriceList { get; set; } = null!;
}
