using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class EntityDynamicImportStaging
{
    public int Id { get; set; }

    public string EntityType { get; set; } = null!;

    public string ImportData { get; set; } = null!;
}
