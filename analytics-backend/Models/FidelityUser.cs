using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class FidelityUser
{
    public string Id { get; set; } = null!;

    public string? Username { get; set; }

    public string? NormalizedUserName { get; set; }

    public string? Email { get; set; }

    public string? NormalizedEmail { get; set; }

    public bool EmailConfirmed { get; set; }

    public string? PasswordHash { get; set; }

    public string? SecurityStamp { get; set; }

    public string? ConcurrencyStamp { get; set; }

    public string? PhoneNumber { get; set; }

    public bool PhoneNumberConfirmed { get; set; }

    public bool TwoFactorEnabled { get; set; }

    public DateTime? LockoutEnd { get; set; }

    public bool LockoutEnabled { get; set; }

    public int AccessFailedCount { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual ICollection<FidelityUserClaim> FidelityUserClaims { get; set; } = new List<FidelityUserClaim>();

    public virtual ICollection<FidelityUserLogin> FidelityUserLogins { get; set; } = new List<FidelityUserLogin>();

    public virtual ICollection<FidelityUserSession> FidelityUserSessions { get; set; } = new List<FidelityUserSession>();

    public virtual ICollection<FidelityUserToken> FidelityUserTokens { get; set; } = new List<FidelityUserToken>();
}
