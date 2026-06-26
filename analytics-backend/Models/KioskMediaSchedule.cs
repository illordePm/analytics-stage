using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class KioskMediaSchedule
{
    public int Id { get; set; }

    public string? Description { get; set; }

    public int? WelcomeMediaId { get; set; }

    public int? TopBannerMediaId { get; set; }

    public DateTime CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Creator { get; set; }

    public string? LastModifier { get; set; }

    public virtual ICollection<KioskMediaScheduleDetail> KioskMediaScheduleDetails { get; set; } = new List<KioskMediaScheduleDetail>();

    public virtual ICollection<PosKiosk> PosKiosks { get; set; } = new List<PosKiosk>();

    public virtual Medium? TopBannerMedia { get; set; }

    public virtual Medium? WelcomeMedia { get; set; }
}
