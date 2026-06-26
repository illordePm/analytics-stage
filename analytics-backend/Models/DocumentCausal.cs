using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class DocumentCausal
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Notes { get; set; }

    public int DocumentTypeId { get; set; }

    public int Context { get; set; }

    public int VisibilityLevel { get; set; }

    public int CausalType { get; set; }

    public int Template { get; set; }

    public bool AllowDirectCreation { get; set; }

    public bool Enabled { get; set; }

    public int? OppositeCausalId { get; set; }

    public bool ShowInvalidArticles { get; set; }

    public DateTime CreationTime { get; set; }

    public string? Creator { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public string? LastModifier { get; set; }

    public string? Columns { get; set; }

    public virtual ICollection<CausalControl> CausalControls { get; set; } = new List<CausalControl>();

    public virtual ICollection<CausalLink> CausalLinkCausals { get; set; } = new List<CausalLink>();

    public virtual ICollection<CausalLink> CausalLinkLinkedCausals { get; set; } = new List<CausalLink>();

    public virtual ICollection<CausalTotal> CausalTotals { get; set; } = new List<CausalTotal>();

    public virtual ICollection<CausalWorkflow> CausalWorkflows { get; set; } = new List<CausalWorkflow>();

    public virtual ICollection<DocumentHeading> DocumentHeadings { get; set; } = new List<DocumentHeading>();

    public virtual ICollection<DocumentRow> DocumentRows { get; set; } = new List<DocumentRow>();

    public virtual DocumentType DocumentType { get; set; } = null!;

    public virtual ICollection<DocumentCausal> InverseOppositeCausal { get; set; } = new List<DocumentCausal>();

    public virtual DocumentCausal? OppositeCausal { get; set; }

    public virtual ICollection<SaleHeading> SaleHeadings { get; set; } = new List<SaleHeading>();

    public virtual ICollection<SaleRow> SaleRows { get; set; } = new List<SaleRow>();

    public virtual ICollection<SaleTransaction> SaleTransactions { get; set; } = new List<SaleTransaction>();

    public virtual ICollection<WarehouseTransaction> WarehouseTransactions { get; set; } = new List<WarehouseTransaction>();

    public virtual ICollection<ShopGroup> ShopGroups { get; set; } = new List<ShopGroup>();
}
