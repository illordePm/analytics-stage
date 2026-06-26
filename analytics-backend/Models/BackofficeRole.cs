using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class BackofficeRole
{
    public string Id { get; set; } = null!;

    public int VisibilityLevel { get; set; }

    public string Code { get; set; } = null!;

    public string? Name { get; set; }

    public string? NormalizedName { get; set; }

    public string? ConcurrencyStamp { get; set; }

    public virtual ICollection<BackofficeRoleClaim> BackofficeRoleClaims { get; set; } = new List<BackofficeRoleClaim>();

    public virtual ICollection<BackofficeUser> Users { get; set; } = new List<BackofficeUser>();
}
