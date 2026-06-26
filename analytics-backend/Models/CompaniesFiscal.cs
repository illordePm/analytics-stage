using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class CompaniesFiscal
{
    public int CompanyId { get; set; }

    public string? FiscalCode { get; set; }

    public string? VatNumber { get; set; }

    public string? Sdi { get; set; }

    public string? BusinessName { get; set; }

    public virtual Company Company { get; set; } = null!;
}
