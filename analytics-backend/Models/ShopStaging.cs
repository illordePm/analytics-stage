using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class ShopStaging
{
    public int Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? BrandCode { get; set; }

    public string? CurrencyCode { get; set; }
}
