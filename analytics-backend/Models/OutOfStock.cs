using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class OutOfStock
{
    public int Id { get; set; }

    public int ArticleId { get; set; }

    public int ShopId { get; set; }

    public virtual Article Article { get; set; } = null!;

    public virtual Shop Shop { get; set; } = null!;
}
