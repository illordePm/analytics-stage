using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class SalePriceListsStaging
{
    public int Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public DateOnly? HeadingValidityFrom { get; set; }

    public DateOnly? HeadingValidityTo { get; set; }

    public bool? HeadingIsValid { get; set; }

    public string? CurrencyCode { get; set; }

    public string? ArticleCode { get; set; }

    public string? SalePriceListCode { get; set; }

    public decimal? Price { get; set; }

    public DateOnly? DetailValidityFrom { get; set; }

    public DateOnly? DetailValidityTo { get; set; }

    public bool? DetailIsValid { get; set; }

    public string? VatCode { get; set; }

    public decimal? BundleAdditionalPrice { get; set; }

    public decimal? UpsellPrice { get; set; }
}
