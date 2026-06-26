using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class CustomerPoint
{
    public int Id { get; set; }

    public int CustomerId { get; set; }

    public int CollectionId { get; set; }

    public DateTime LastUpdateDate { get; set; }

    public decimal PointsAmount { get; set; }

    public DateTime CreationTime { get; set; }

    public string? Creator { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public string? LastModifier { get; set; }

    public bool IsDeleted { get; set; }

    public string? Deleter { get; set; }

    public DateTime? DeletionTime { get; set; }

    public virtual CustomerPointsCollection Collection { get; set; } = null!;

    public virtual Customer Customer { get; set; } = null!;
}
