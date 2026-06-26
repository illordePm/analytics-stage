using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class BackofficeUserToken
{
    public string UserId { get; set; } = null!;

    public string LoginProvider { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Value { get; set; }

    public virtual BackofficeUser User { get; set; } = null!;
}
