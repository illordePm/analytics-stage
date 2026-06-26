using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class DocumentRecent
{
    public string OperatorId { get; set; } = null!;

    public int DocumentId { get; set; }

    public DateTime Timestamp { get; set; }

    public virtual DocumentHeading Document { get; set; } = null!;

    public virtual BackofficeUser Operator { get; set; } = null!;
}
