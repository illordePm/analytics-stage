using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class MediaScheduleDetailsView
{
    public int? Id { get; set; }

    public int? MediaScheduleId { get; set; }

    public int? WelcomeMediaId { get; set; }

    public int? TopBannerMediaId { get; set; }

    public DateOnly? StartDate { get; set; }

    public TimeOnly? StartTime { get; set; }

    public DateOnly? EndDate { get; set; }

    public TimeOnly? EndTime { get; set; }

    public string? Weekdays { get; set; }
}
