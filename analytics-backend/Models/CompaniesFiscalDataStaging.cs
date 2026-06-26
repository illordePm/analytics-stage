using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class CompaniesFiscalDataStaging
{
    public int Id { get; set; }

    public string CompanyCode { get; set; } = null!;

    public string? FiscalCode { get; set; }

    public string? VatNumber { get; set; }

    public string? Sdi { get; set; }
}
