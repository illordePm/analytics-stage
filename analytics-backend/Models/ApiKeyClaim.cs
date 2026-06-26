using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class ApiKeyClaim
{
    public int Id { get; set; }

    public int ApiKeyId { get; set; }

    public string ClaimType { get; set; } = null!;

    public string ClaimValue { get; set; } = null!;

    public virtual ApiKey ApiKey { get; set; } = null!;
}
