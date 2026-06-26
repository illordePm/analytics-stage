using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class UpsellSetsView
{
    public int? Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public DateOnly? StartDate { get; set; }

    public TimeOnly? StartTime { get; set; }

    public DateOnly? EndDate { get; set; }

    public TimeOnly? EndTime { get; set; }

    public string? Weekdays { get; set; }
}
