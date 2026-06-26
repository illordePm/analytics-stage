using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class StockField
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public int Order { get; set; }

    public int VisibilityLevel { get; set; }

    public bool IsCostField { get; set; }

    public bool IsActualQuantityField { get; set; }

    public bool IsSystem { get; set; }

    public int Type { get; set; }

    public virtual ICollection<CausalOperation> CausalOperations { get; set; } = new List<CausalOperation>();

    public virtual ICollection<DailyStockValue> DailyStockValues { get; set; } = new List<DailyStockValue>();

    public virtual ICollection<StockValue> StockValues { get; set; } = new List<StockValue>();
}
