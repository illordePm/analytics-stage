using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class Stock
{
    public int Id { get; set; }

    public int WarehouseId { get; set; }

    public int ArticleId { get; set; }

    public bool IsValid { get; set; }

    public DateTime CreationTime { get; set; }

    public string? Creator { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public string? LastModifier { get; set; }

    public bool IsDeleted { get; set; }

    public string? Deleter { get; set; }

    public DateTime? DeletionTime { get; set; }

    public virtual Article Article { get; set; } = null!;

    public virtual ICollection<DailyStockValue> DailyStockValues { get; set; } = new List<DailyStockValue>();

    public virtual ICollection<StockValue> StockValues { get; set; } = new List<StockValue>();

    public virtual ShopWarehouse Warehouse { get; set; } = null!;
}
