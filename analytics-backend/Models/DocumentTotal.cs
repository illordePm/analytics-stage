using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class DocumentTotal
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public int TotalType { get; set; }

    public bool ApplyDiscounts { get; set; }

    public string ValueStatement { get; set; } = null!;

    public string? LabelStatement { get; set; }

    public string FixedLabel { get; set; } = null!;

    public DateTime CreationTime { get; set; }

    public string? Creator { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public string? LastModifier { get; set; }

    public virtual ICollection<CausalTotal> CausalTotals { get; set; } = new List<CausalTotal>();

    public virtual ICollection<DocumentTotalsAmount> DocumentTotalsAmounts { get; set; } = new List<DocumentTotalsAmount>();
}
