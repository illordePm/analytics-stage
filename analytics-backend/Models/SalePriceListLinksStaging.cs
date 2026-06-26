using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class SalePriceListLinksStaging
{
    public int Id { get; set; }

    public string? SalePriceListCode { get; set; }

    public string? ShopCode { get; set; }

    public string? PosCode { get; set; }

    public string? ServiceTypeCode { get; set; }

    public int? OrderNum { get; set; }
}
