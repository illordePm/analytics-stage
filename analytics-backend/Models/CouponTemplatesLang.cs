using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class CouponTemplatesLang
{
    public int CouponTemplateId { get; set; }

    public string LanguageCode { get; set; } = null!;

    public string? PublicName { get; set; }

    public string? Description { get; set; }

    public string? TermsAndConditions { get; set; }

    public int? MediaId { get; set; }

    public virtual CouponTemplate CouponTemplate { get; set; } = null!;

    public virtual Medium? Media { get; set; }
}
