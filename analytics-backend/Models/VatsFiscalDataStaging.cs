using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class VatsFiscalDataStaging
{
    public int Id { get; set; }

    public string VatCode { get; set; } = null!;

    public string? PrinterIndex { get; set; }

    public string? DepartmentCode { get; set; }

    public string? ExemptionKindCode { get; set; }

    public int? SalesAttribute { get; set; }

    public int? SalesType { get; set; }

    public string? AtecoCode { get; set; }
}
