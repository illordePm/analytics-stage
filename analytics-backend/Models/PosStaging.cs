using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class PosStaging
{
    public int Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public int? PosType { get; set; }

    public string? ExternalId { get; set; }

    public string? ShopCode { get; set; }
}
