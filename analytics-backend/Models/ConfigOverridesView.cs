using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class ConfigOverridesView
{
    public int? Id { get; set; }

    public int? ConfigId { get; set; }

    public string? Value { get; set; }

    public int? KioskId { get; set; }

    public int? ShopId { get; set; }
}
