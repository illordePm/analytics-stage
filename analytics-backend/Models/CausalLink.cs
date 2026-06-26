using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class CausalLink
{
    public int Id { get; set; }

    public int CausalId { get; set; }

    public int LinkedCausalId { get; set; }

    public string? SqlStatement { get; set; }

    public bool ConcludeAutomatically { get; set; }

    public bool Enabled { get; set; }

    public virtual DocumentCausal Causal { get; set; } = null!;

    public virtual DocumentCausal LinkedCausal { get; set; } = null!;
}
