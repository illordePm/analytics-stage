using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class CausalTotal
{
    public int Id { get; set; }

    public int CausalId { get; set; }

    public int TotalId { get; set; }

    public int VisibilityLevel { get; set; }

    public virtual DocumentCausal Causal { get; set; } = null!;

    public virtual DocumentTotal Total { get; set; } = null!;
}
