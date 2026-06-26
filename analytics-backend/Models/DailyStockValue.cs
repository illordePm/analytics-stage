using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class DailyStockValue
{
    public int Id { get; set; }

    public int StockFieldId { get; set; }

    public int StockId { get; set; }

    public DateOnly StockDate { get; set; }

    public decimal Value { get; set; }

    public int OperationsCount { get; set; }

    public virtual Stock Stock { get; set; } = null!;

    public virtual StockField StockField { get; set; } = null!;
}
