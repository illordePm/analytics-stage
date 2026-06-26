using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class UpsellSet
{
    public int Id { get; set; }

    public string? Description { get; set; }

    public DateOnly StartDate { get; set; }

    public TimeOnly StartTime { get; set; }

    public DateOnly EndDate { get; set; }

    public TimeOnly EndTime { get; set; }

    public string Weekdays { get; set; } = null!;

    public DateTime CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Creator { get; set; }

    public string? LastModifier { get; set; }

    public virtual ICollection<UpsellSetDetail> UpsellSetDetails { get; set; } = new List<UpsellSetDetail>();

    public virtual ICollection<UpsellSetLink> UpsellSetLinks { get; set; } = new List<UpsellSetLink>();
}
