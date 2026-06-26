using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class MeasUnitsConversion
{
    public int Id { get; set; }

    public int FromMeasUnitId { get; set; }

    public int ToMeasUnitId { get; set; }

    public decimal Value { get; set; }

    public string? Notes { get; set; }

    public virtual MeasUnit FromMeasUnit { get; set; } = null!;

    public virtual MeasUnit ToMeasUnit { get; set; } = null!;
}
