using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class ConfigsView
{
    public int? Id { get; set; }

    public string? Key { get; set; }

    public string? Description { get; set; }

    public string? DefaultValue { get; set; }
}
