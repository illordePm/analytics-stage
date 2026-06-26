using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class BackofficeUser
{
    public string Id { get; set; } = null!;

    public string Code { get; set; } = null!;

    public string? FullName { get; set; }

    public DateTime? AccessStartDate { get; set; }

    public DateTime? AccessEndDate { get; set; }

    public DateTime? DateOfBirth { get; set; }

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

    public virtual ICollection<BackofficeUserClaim> BackofficeUserClaims { get; set; } = new List<BackofficeUserClaim>();

    public virtual ICollection<BackofficeUserLogin> BackofficeUserLogins { get; set; } = new List<BackofficeUserLogin>();

    public virtual ICollection<BackofficeUserSession> BackofficeUserSessions { get; set; } = new List<BackofficeUserSession>();

    public virtual ICollection<BackofficeUserToken> BackofficeUserTokens { get; set; } = new List<BackofficeUserToken>();

    public virtual ICollection<DocumentRecent> DocumentRecents { get; set; } = new List<DocumentRecent>();

    public virtual ICollection<BackofficeRole> Roles { get; set; } = new List<BackofficeRole>();

    public virtual ICollection<Shop> Shops { get; set; } = new List<Shop>();
}
