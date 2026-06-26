using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class BackofficeUserSession
{
    public string SessionId { get; set; } = null!;

    public string UserId { get; set; } = null!;

    public string RefreshToken { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime ExpiresAt { get; set; }

    public virtual BackofficeUser User { get; set; } = null!;
}
