using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class SalePriceListLink
{
    public int Id { get; set; }

    public int SalePriceListId { get; set; }

    public int? ShopId { get; set; }

    public int? PosId { get; set; }

    public string? ServiceTypeCode { get; set; }

    public int OrderNum { get; set; }

    public virtual Po? Pos { get; set; }

    public virtual SalePriceList SalePriceList { get; set; } = null!;

    public virtual Shop? Shop { get; set; }
}
