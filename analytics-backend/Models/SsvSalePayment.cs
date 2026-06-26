using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class SsvSalePayment
{
    public DateOnly? AccountingDate { get; set; }

    public int? LastExportDate { get; set; }

    public int? ShopId { get; set; }

    public string? ShopCode { get; set; }

    public string? ShopDesc { get; set; }

    public string? PaymentCode { get; set; }

    public string? PaymentDesc { get; set; }

    public string? PaymentNotes { get; set; }

    public decimal? Amount { get; set; }
}
