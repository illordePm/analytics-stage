using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class KiosksView
{
    public int? Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public int? PosType { get; set; }

    public int? ShopId { get; set; }

    public string? ExternalId { get; set; }

    public bool? CashPaymentEnabled { get; set; }

    public bool? CreditCardPaymentEnabled { get; set; }

    public int? MediaScheduleId { get; set; }

    public string? Languages { get; set; }

    public bool? TableServiceEnabled { get; set; }

    public bool? TakeAwayEnabled { get; set; }

    public int? LayoutScheduleId { get; set; }
}
