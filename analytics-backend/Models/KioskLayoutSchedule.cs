using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class KioskLayoutSchedule
{
    public int Id { get; set; }

    public string? Description { get; set; }

    public int DefaultLayoutId { get; set; }

    public DateTime CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Creator { get; set; }

    public string? LastModifier { get; set; }

    public virtual KioskLayout DefaultLayout { get; set; } = null!;

    public virtual ICollection<KioskLayoutScheduleDetail> KioskLayoutScheduleDetails { get; set; } = new List<KioskLayoutScheduleDetail>();

    public virtual ICollection<PosKiosk> PosKiosks { get; set; } = new List<PosKiosk>();
}
