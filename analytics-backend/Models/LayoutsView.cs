using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class LayoutsView
{
    public int? Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }
}
