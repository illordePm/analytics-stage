using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class CausalOperation
{
    public int Id { get; set; }

    public int OrderNum { get; set; }

    public int CausalWorkflowId { get; set; }

    public int StockFieldId { get; set; }

    public int Task { get; set; }

    public bool Enabled { get; set; }

    public virtual CausalWorkflow CausalWorkflow { get; set; } = null!;

    public virtual StockField StockField { get; set; } = null!;
}
