using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class VatsStaging
{
    public int Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public decimal? Percent { get; set; }

    public bool? IsValid { get; set; }
}
