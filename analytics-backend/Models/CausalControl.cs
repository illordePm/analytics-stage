using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class CausalControl
{
    public int Id { get; set; }

    public int CausalId { get; set; }

    public int DocumentControlId { get; set; }

    public int ControlLevel { get; set; }

    public bool Enabled { get; set; }

    public virtual DocumentCausal Causal { get; set; } = null!;

    public virtual DocumentControl DocumentControl { get; set; } = null!;
}
