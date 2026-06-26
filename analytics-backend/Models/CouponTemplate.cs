using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class CouponTemplate
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public int BrandId { get; set; }

    public string? PublicName { get; set; }

    public string? Description { get; set; }

    public int? MediaId { get; set; }

    public int CouponType { get; set; }

    public int TriggerEvent { get; set; }

    public string? PromotionCode { get; set; }

    public decimal? FixedValue { get; set; }

    public int CodeGenerationType { get; set; }

    public string? RandomCodePrefix { get; set; }

    public string? RandomCodeSuffix { get; set; }

    public int? RandomCodeLength { get; set; }

    public string? FixedCode { get; set; }

    public int ValidityPeriodType { get; set; }

    public int RecurrenceType { get; set; }

    public int? ValidityDays { get; set; }

    public int? UsageTimeLimitMinutes { get; set; }

    public DateTime? ValidFrom { get; set; }

    public DateTime? ValidTo { get; set; }

    public TimeOnly? StartTime { get; set; }

    public TimeOnly? EndTime { get; set; }

    public string? Weekdays { get; set; }

    public bool IsActive { get; set; }

    public bool System { get; set; }

    public int? MaxTotalUsage { get; set; }

    public string? TermsAndConditions { get; set; }

    public bool? IsPublic { get; set; }

    public int? SegmentationRuleId { get; set; }

    public DateTime CreationTime { get; set; }

    public string? Creator { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public string? LastModifier { get; set; }

    public int? CustomerGroupId { get; set; }

    public virtual Brand Brand { get; set; } = null!;

    public virtual ICollection<CouponTemplatesLang> CouponTemplatesLangs { get; set; } = new List<CouponTemplatesLang>();

    public virtual ICollection<Coupon> Coupons { get; set; } = new List<Coupon>();

    public virtual CustomersGroup? CustomerGroup { get; set; }

    public virtual Medium? Media { get; set; }

    public virtual CouponSegmentationRule? SegmentationRule { get; set; }
}
