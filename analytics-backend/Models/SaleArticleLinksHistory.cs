using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class SaleArticleLinksHistory
{
    public int Id { get; set; }

    public int SaleArticleId { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public int? OldWarehouseArticleId { get; set; }

    public int? NewWarehouseArticleId { get; set; }

    public int? OldRecipeId { get; set; }

    public int? NewRecipeId { get; set; }

    public decimal? OldPortionFactor { get; set; }

    public decimal? NewPortionFactor { get; set; }

    public bool? OldUnloadable { get; set; }

    public bool? NewUnloadable { get; set; }

    public DateTime? SchedulingDate { get; set; }

    public string? ScheduledJobId { get; set; }

    public virtual Recipe? NewRecipe { get; set; }

    public virtual Article? NewWarehouseArticle { get; set; }

    public virtual Recipe? OldRecipe { get; set; }

    public virtual Article? OldWarehouseArticle { get; set; }

    public virtual Article SaleArticle { get; set; } = null!;
}
