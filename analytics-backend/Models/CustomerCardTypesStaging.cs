using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class CustomerCardTypesStaging
{
    public int Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? IdentificationRule { get; set; }

    public string? GenerationRule { get; set; }
}
