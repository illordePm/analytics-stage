using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class UiGroupLayoutsLinksView
{
    public int? LayoutId { get; set; }

    public int? UiGroupId { get; set; }

    public bool? IsDefault { get; set; }

    public string? ValidForServiceTypes { get; set; }

    public int? OrderNum { get; set; }
}
