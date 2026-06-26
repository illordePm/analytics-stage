using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class BackofficeRoleClaim
{
    public int Id { get; set; }

    public string RoleId { get; set; } = null!;

    public string? ClaimType { get; set; }

    public string? ClaimValue { get; set; }

    public virtual BackofficeRole Role { get; set; } = null!;
}
