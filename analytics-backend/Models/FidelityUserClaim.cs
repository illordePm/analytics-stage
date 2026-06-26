using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class FidelityUserClaim
{
    public int Id { get; set; }

    public string UserId { get; set; } = null!;

    public string? ClaimType { get; set; }

    public string? ClaimValue { get; set; }

    public virtual FidelityUser User { get; set; } = null!;
}
