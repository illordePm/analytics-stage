using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class CustomerCardType
{
    public int Id { get; set; }

    public string IdentificationRule { get; set; } = null!;

    public string GenerationRule { get; set; } = null!;

    public DateTime CreationTime { get; set; }

    public string? Creator { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public string? LastModifier { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public virtual ICollection<CustomerCard> CustomerCards { get; set; } = new List<CustomerCard>();
}
