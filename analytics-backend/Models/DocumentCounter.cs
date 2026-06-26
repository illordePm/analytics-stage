using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class DocumentCounter
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public int EnumerationType { get; set; }

    public int ResetRule { get; set; }

    public bool YearPrefix { get; set; }

    public DateTime CreationTime { get; set; }

    public string? Creator { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public string? LastModifier { get; set; }

    public virtual ICollection<DocumentType> DocumentTypes { get; set; } = new List<DocumentType>();
}
