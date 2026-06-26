using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class SaleArticleLink
{
    public int SaleArticleId { get; set; }

    public int? WarehouseArticleId { get; set; }

    public int? RecipeId { get; set; }

    public decimal PortionFactor { get; set; }

    public bool Unloadable { get; set; }

    public virtual Recipe? Recipe { get; set; }

    public virtual Article SaleArticle { get; set; } = null!;

    public virtual Article? WarehouseArticle { get; set; }
}
