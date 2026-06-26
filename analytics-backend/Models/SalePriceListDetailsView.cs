using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class SalePriceListDetailsView
{
    public int? Id { get; set; }

    public int? ArticleId { get; set; }

    public int? SalePriceListId { get; set; }

    public decimal? Price { get; set; }

    public decimal? UpsellPrice { get; set; }

    public decimal? BundleAdditionalPrice { get; set; }

    public DateOnly? ValidityFrom { get; set; }

    public DateOnly? ValidityTo { get; set; }

    public bool? IsValid { get; set; }

    public int? VatId { get; set; }
}
