using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class FidelityEvent
{
    public int Id { get; set; }

    public int Type { get; set; }

    public int BrandId { get; set; }

    public bool GenerateCoupon { get; set; }

    public bool SendEmail { get; set; }

    public string? EmailTemplateId { get; set; }

    public int? CouponOffsetDays { get; set; }

    public virtual Brand Brand { get; set; } = null!;
}
