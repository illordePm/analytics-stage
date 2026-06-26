using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class SalePriceListsView
{
    public int? Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public DateOnly? ValidityFrom { get; set; }

    public DateOnly? ValidityTo { get; set; }

    public bool? IsValid { get; set; }
}
