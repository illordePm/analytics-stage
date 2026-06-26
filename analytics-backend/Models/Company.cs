using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class Company
{
    public int Id { get; set; }

    public int? AddressId { get; set; }

    public DateTime CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Creator { get; set; }

    public string? LastModifier { get; set; }

    public virtual Address? Address { get; set; }

    public virtual CompaniesFiscal? CompaniesFiscal { get; set; }

    public virtual ICollection<Shop> Shops { get; set; } = new List<Shop>();

    public virtual ICollection<Address> Addresses { get; set; } = new List<Address>();
}
