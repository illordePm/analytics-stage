using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class CustomerFiscal
{
    public int CustomerId { get; set; }

    public int? ReferenceCustomerId { get; set; }

    public string? FiscalCode { get; set; }

    public string? VatNumber { get; set; }

    public string? SdiCode { get; set; }

    public string? PecAddress { get; set; }

    public string? BusinessName { get; set; }

    public bool UseSplitPayment { get; set; }

    public bool IsGovernment { get; set; }

    public virtual Customer Customer { get; set; } = null!;

    public virtual Customer? ReferenceCustomer { get; set; }
}
