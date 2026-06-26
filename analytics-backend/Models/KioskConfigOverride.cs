using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class KioskConfigOverride
{
    public int Id { get; set; }

    public int ConfigId { get; set; }

    public string Value { get; set; } = null!;

    public int? KioskId { get; set; }

    public int? ShopId { get; set; }

    public virtual KioskConfig Config { get; set; } = null!;

    public virtual PosKiosk? Kiosk { get; set; }

    public virtual Shop? Shop { get; set; }
}
