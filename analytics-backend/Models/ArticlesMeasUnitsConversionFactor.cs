using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class ArticlesMeasUnitsConversionFactor
{
    public int Id { get; set; }

    public int ArticleId { get; set; }

    public int MeasUnitId { get; set; }

    public decimal Value { get; set; }

    public string? Notes { get; set; }

    public virtual Article Article { get; set; } = null!;

    public virtual MeasUnit MeasUnit { get; set; } = null!;
}
