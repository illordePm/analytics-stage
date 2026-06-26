using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class CausalWorkflow
{
    public int Id { get; set; }

    public int CausalId { get; set; }

    public int? FromStateId { get; set; }

    public int? ToStateId { get; set; }

    public virtual DocumentCausal Causal { get; set; } = null!;

    public virtual ICollection<CausalOperation> CausalOperations { get; set; } = new List<CausalOperation>();

    public virtual DocumentState? FromState { get; set; }

    public virtual DocumentState? ToState { get; set; }
}
