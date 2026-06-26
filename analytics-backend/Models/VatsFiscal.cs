using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class VatsFiscal
{
    public int VatId { get; set; }

    public string? PrinterIndex { get; set; }

    public string? DepartmentCode { get; set; }

    public string? ExemptionKindCode { get; set; }

    public int? SalesAttribute { get; set; }

    public int? SalesType { get; set; }

    public string? AtecoCode { get; set; }

    public virtual VatsExemptionKind? ExemptionKindCodeNavigation { get; set; }

    public virtual Vat Vat { get; set; } = null!;
}
