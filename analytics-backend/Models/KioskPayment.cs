using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class KioskPayment
{
    public int Id { get; set; }

    public int? MediaId { get; set; }

    public DateTime CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Creator { get; set; }

    public string? LastModifier { get; set; }

    public virtual Medium? Media { get; set; }
}
