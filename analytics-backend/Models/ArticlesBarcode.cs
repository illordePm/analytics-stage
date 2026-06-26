using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class ArticlesBarcode
{
    public int Id { get; set; }

    public int ArticleId { get; set; }

    public string Barcode { get; set; } = null!;

    public decimal? Quantity { get; set; }

    public virtual Article Article { get; set; } = null!;
}
