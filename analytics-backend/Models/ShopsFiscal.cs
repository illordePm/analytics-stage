using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class ShopsFiscal
{
    public int ShopId { get; set; }

    public string? FiscalCode { get; set; }

    public string? VatNumber { get; set; }

    public string? Sdi { get; set; }

    public string? BusinessName { get; set; }

    public virtual Shop Shop { get; set; } = null!;
}
