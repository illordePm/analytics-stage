using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class DocumentState
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public bool Enabled { get; set; }

    public int VisibilityLevel { get; set; }

    public virtual ICollection<CausalWorkflow> CausalWorkflowFromStates { get; set; } = new List<CausalWorkflow>();

    public virtual ICollection<CausalWorkflow> CausalWorkflowToStates { get; set; } = new List<CausalWorkflow>();

    public virtual ICollection<DocumentHeading> DocumentHeadings { get; set; } = new List<DocumentHeading>();

    public virtual ICollection<DocumentWorkflow> DocumentWorkflows { get; set; } = new List<DocumentWorkflow>();

    public virtual ICollection<SaleTransaction> SaleTransactions { get; set; } = new List<SaleTransaction>();

    public virtual ICollection<WarehouseTransaction> WarehouseTransactions { get; set; } = new List<WarehouseTransaction>();
}
