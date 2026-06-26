using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class UiTileTemplatesView
{
    public int? Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public bool? ShowName { get; set; }

    public bool? ShowDescription { get; set; }

    public bool? ShowPrice { get; set; }

    public bool? IsBackground { get; set; }

    public string? CssClass { get; set; }
}
