using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class StockValue
{
    public int Id { get; set; }

    public int StockFieldId { get; set; }

    public int StockId { get; set; }

    public decimal Value { get; set; }

    public DateTime LastUpdateDate { get; set; }

    public int OperationsCount { get; set; }

    public virtual Stock Stock { get; set; } = null!;

    public virtual StockField StockField { get; set; } = null!;
}
