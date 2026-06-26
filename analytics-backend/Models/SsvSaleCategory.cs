using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class SsvSaleCategory
{
    public DateOnly? AccountingDate { get; set; }

    public int? LastExportDate { get; set; }

    public int? ShopId { get; set; }

    public string? ShopCode { get; set; }

    public string? ShopDesc { get; set; }

    public string? AccountType { get; set; }

    public string? AccountCode { get; set; }

    public decimal? Amount { get; set; }

    public decimal? NetAmount { get; set; }
}
