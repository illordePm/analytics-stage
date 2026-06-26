using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class FidelityConfig
{
    public int Id { get; set; }

    public string Key { get; set; } = null!;

    public string? Description { get; set; }

    public string? DefaultValue { get; set; }

    public string Type { get; set; } = null!;

    public int BrandId { get; set; }

    public virtual Brand Brand { get; set; } = null!;
}
