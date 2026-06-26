using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class KioskUiGroupLayoutsLink
{
    public int LayoutId { get; set; }

    public int KioskUiGroupId { get; set; }

    public bool IsDefault { get; set; }

    public string ValidForServiceTypes { get; set; } = null!;

    public int? OrderNum { get; set; }

    public virtual KioskUiGroup KioskUiGroup { get; set; } = null!;

    public virtual KioskLayout Layout { get; set; } = null!;
}
