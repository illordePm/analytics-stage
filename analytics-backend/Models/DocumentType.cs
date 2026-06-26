using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class DocumentType
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public int DocumentCounterId { get; set; }

    public bool Enabled { get; set; }

    public int Context { get; set; }

    public DateTime CreationTime { get; set; }

    public string? Creator { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public string? LastModifier { get; set; }

    public virtual ICollection<DocumentCausal> DocumentCausals { get; set; } = new List<DocumentCausal>();

    public virtual ICollection<DocumentCode> DocumentCodes { get; set; } = new List<DocumentCode>();

    public virtual DocumentCounter DocumentCounter { get; set; } = null!;

    public virtual ICollection<DocumentHeading> DocumentHeadings { get; set; } = new List<DocumentHeading>();
}
