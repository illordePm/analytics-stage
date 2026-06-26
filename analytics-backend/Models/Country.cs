using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class Country
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Alpha2 { get; set; } = null!;

    public string Alpha3 { get; set; } = null!;

    public DateTime CreationTime { get; set; }

    public string? Creator { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public string? LastModifier { get; set; }

    public virtual ICollection<Address> Addresses { get; set; } = new List<Address>();
}
