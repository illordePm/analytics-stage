using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class CustomerCard
{
    public int Id { get; set; }

    public int CustomerId { get; set; }

    public string CardNumber { get; set; } = null!;

    public DateTime IssueDate { get; set; }

    public DateTime? ExpirationDate { get; set; }

    public bool Enabled { get; set; }

    public int CardTypeId { get; set; }

    public DateTime CreationTime { get; set; }

    public string? Creator { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public string? LastModifier { get; set; }

    public bool IsDeleted { get; set; }

    public string? Deleter { get; set; }

    public DateTime? DeletionTime { get; set; }

    public virtual CustomerCardType CardType { get; set; } = null!;

    public virtual Customer Customer { get; set; } = null!;
}
