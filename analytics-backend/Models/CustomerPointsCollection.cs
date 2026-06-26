using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class CustomerPointsCollection
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public bool IsValid { get; set; }

    public DateTime CreationTime { get; set; }

    public string? Creator { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public string? LastModifier { get; set; }

    public int BrandId { get; set; }

    public virtual Brand Brand { get; set; } = null!;

    public virtual ICollection<CustomerPoint> CustomerPoints { get; set; } = new List<CustomerPoint>();

    public virtual ICollection<CustomerPointsTransaction> CustomerPointsTransactions { get; set; } = new List<CustomerPointsTransaction>();
}
