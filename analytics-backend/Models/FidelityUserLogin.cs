using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class FidelityUserLogin
{
    public string LoginProvider { get; set; } = null!;

    public string ProviderKey { get; set; } = null!;

    public string? ProviderDisplayName { get; set; }

    public string UserId { get; set; } = null!;

    public virtual FidelityUser User { get; set; } = null!;
}
