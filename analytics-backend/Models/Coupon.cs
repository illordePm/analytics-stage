using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class Coupon
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public bool Enabled { get; set; }

    public int TemplateId { get; set; }

    public DateTime CreationTime { get; set; }

    public string? Creator { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public string? LastModifier { get; set; }

    public bool IsDeleted { get; set; }

    public string? Deleter { get; set; }

    public DateTime? DeletionTime { get; set; }

    public int? CustomerId { get; set; }

    public decimal? FixedValue { get; set; }

    public DateTime? LastUsageDate { get; set; }

    public int? LastUsageShopId { get; set; }

    public string? LockedBy { get; set; }

    public DateTime? LockedUntil { get; set; }

    public int? MaxUsage { get; set; }

    public string? PromotionCode { get; set; }

    public int UsageCount { get; set; }

    public DateTime? ValidFrom { get; set; }

    public DateTime? ValidTo { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual Shop? LastUsageShop { get; set; }

    public virtual CouponTemplate Template { get; set; } = null!;
}
