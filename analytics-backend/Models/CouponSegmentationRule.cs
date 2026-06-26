using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class CouponSegmentationRule
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Query { get; set; } = null!;

    public virtual ICollection<CouponTemplate> CouponTemplates { get; set; } = new List<CouponTemplate>();
}
