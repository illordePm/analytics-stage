using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class PaymentsView
{
    public int? Id { get; set; }

    public int? MediaId { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }
}
