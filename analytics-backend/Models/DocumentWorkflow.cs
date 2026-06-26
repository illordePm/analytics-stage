using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class DocumentWorkflow
{
    public int Id { get; set; }

    public int HeadingId { get; set; }

    public int StateId { get; set; }

    public string Operator { get; set; } = null!;

    public DateTime Timestamp { get; set; }

    public string? Notes { get; set; }

    public virtual DocumentHeading Heading { get; set; } = null!;

    public virtual DocumentState State { get; set; } = null!;
}
