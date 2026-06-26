using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class SaleRow
{
    public int Id { get; set; }

    public int HeadingId { get; set; }

    public int SaleArticleId { get; set; }

    public int? SalePriceListId { get; set; }

    public int? VatId { get; set; }

    public int? MeasUnitId { get; set; }

    public decimal? ConversionFactor { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? Price { get; set; }

    public decimal? Discount { get; set; }

    public decimal? RowTotalPrice { get; set; }

    public bool Deleted { get; set; }

    public int? DetailOrder { get; set; }

    public int? SaleCausalId { get; set; }

    public decimal? PromotionDiscount { get; set; }

    public decimal? ReferencePrice { get; set; }

    public int? DeleteOperatorId { get; set; }

    public bool DontPrint { get; set; }

    public decimal? VatPercent { get; set; }

    public int? ExternalId { get; set; }

    public int? SellerId { get; set; }

    public int? MenuId { get; set; }

    public string? RowType { get; set; }

    public decimal? NetPrice { get; set; }

    public decimal? NetDiscount { get; set; }

    public decimal? PromotionNetDiscount { get; set; }

    public decimal? RowNetTotalPrice { get; set; }

    public virtual SaleHeading Heading { get; set; } = null!;

    public virtual MeasUnit? MeasUnit { get; set; }

    public virtual Article SaleArticle { get; set; } = null!;

    public virtual DocumentCausal? SaleCausal { get; set; }

    public virtual SalePriceList? SalePriceList { get; set; }

    public virtual Vat? Vat { get; set; }
}
