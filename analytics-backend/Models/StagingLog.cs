using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class StagingLog
{
    public int Id { get; set; }

    public string? EntityType { get; set; }

    public string? EntityKey { get; set; }

    public DateTime? InsertTs { get; set; }

    public string? LogMessage { get; set; }

    public bool Notified { get; set; }

    public bool IsError { get; set; }
}
