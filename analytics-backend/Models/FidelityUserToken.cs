using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class FidelityUserToken
{
    public string UserId { get; set; } = null!;

    public string LoginProvider { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Value { get; set; }

    public virtual FidelityUser User { get; set; } = null!;
}
