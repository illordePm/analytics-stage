using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class LayoutScheduleDetailsView
{
    public int? Id { get; set; }

    public int? LayoutScheduleId { get; set; }

    public int? LayoutId { get; set; }

    public DateOnly? StartDate { get; set; }

    public TimeOnly? StartTime { get; set; }

    public DateOnly? EndDate { get; set; }

    public TimeOnly? EndTime { get; set; }

    public string? Weekdays { get; set; }
}
