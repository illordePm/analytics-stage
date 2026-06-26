using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class KioskMediaScheduleDetail
{
    public int MediaScheduleId { get; set; }

    public int? WelcomeMediaId { get; set; }

    public int? TopBannerMediaId { get; set; }

    public DateOnly StartDate { get; set; }

    public TimeOnly StartTime { get; set; }

    public DateOnly EndDate { get; set; }

    public TimeOnly EndTime { get; set; }

    public string Weekdays { get; set; } = null!;

    public int Id { get; set; }

    public virtual KioskMediaSchedule MediaSchedule { get; set; } = null!;

    public virtual Medium? TopBannerMedia { get; set; }

    public virtual Medium? WelcomeMedia { get; set; }
}
