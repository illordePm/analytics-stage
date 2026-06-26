using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class CustomerConsentsHistory
{
    public int Id { get; set; }

    public int CustomerId { get; set; }

    public bool Accepted { get; set; }

    public int ConsentType { get; set; }

    public DateTime Timestamp { get; set; }

    public string? Notes { get; set; }

    public virtual Customer Customer { get; set; } = null!;
}
