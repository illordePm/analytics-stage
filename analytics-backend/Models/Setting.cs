using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class Setting
{
    public int Id { get; set; }

    public string Key { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string? Value { get; set; }

    public string Type { get; set; } = null!;
}
