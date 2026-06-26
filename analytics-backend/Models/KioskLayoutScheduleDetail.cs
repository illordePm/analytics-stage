using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class KioskLayoutScheduleDetail
{
    public int LayoutScheduleId { get; set; }

    public int LayoutId { get; set; }

    public DateOnly StartDate { get; set; }

    public TimeOnly StartTime { get; set; }

    public DateOnly EndDate { get; set; }

    public TimeOnly EndTime { get; set; }

    public string Weekdays { get; set; } = null!;

    public int Id { get; set; }

    public virtual KioskLayout Layout { get; set; } = null!;

    public virtual KioskLayoutSchedule LayoutSchedule { get; set; } = null!;
}
