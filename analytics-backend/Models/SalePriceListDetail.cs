using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class SalePriceListDetail
{
    public int Id { get; set; }

    public int ArticleId { get; set; }

    public int SalePriceListId { get; set; }

    public decimal Price { get; set; }

    public DateOnly? ValidityFrom { get; set; }

    public DateOnly? ValidityTo { get; set; }

    public bool IsValid { get; set; }

    public int? VatId { get; set; }

    public decimal? BundleAdditionalPrice { get; set; }

    public decimal? UpsellPrice { get; set; }

    public virtual Article Article { get; set; } = null!;

    public virtual SalePriceList SalePriceList { get; set; } = null!;

    public virtual Vat? Vat { get; set; }
}
