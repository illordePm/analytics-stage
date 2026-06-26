using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class OutOfStockView
{
    public int? Id { get; set; }

    public int? ShopId { get; set; }

    public int? ArticleId { get; set; }
}
