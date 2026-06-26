using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class VatsExemptionKind
{
    public string Code { get; set; } = null!;

    public string Label { get; set; } = null!;

    public virtual ICollection<VatsFiscal> VatsFiscals { get; set; } = new List<VatsFiscal>();
}
