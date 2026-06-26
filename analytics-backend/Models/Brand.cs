using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class Brand
{
    public int Id { get; set; }

    public DateTime CreationTime { get; set; }

    public string? Creator { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public string? LastModifier { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Email { get; set; }

    public string? FacebookUrl { get; set; }

    public string? InstagramUrl { get; set; }

    public string? LinkedinUrl { get; set; }

    public int? LogoId { get; set; }

    public string? PhoneNumber { get; set; }

    public string? WebsiteUrl { get; set; }

    public string? XUrl { get; set; }

    public virtual ICollection<CouponTemplate> CouponTemplates { get; set; } = new List<CouponTemplate>();

    public virtual ICollection<CustomerPointsCollection> CustomerPointsCollections { get; set; } = new List<CustomerPointsCollection>();

    public virtual ICollection<FidelityConfig> FidelityConfigs { get; set; } = new List<FidelityConfig>();

    public virtual ICollection<FidelityEvent> FidelityEvents { get; set; } = new List<FidelityEvent>();

    public virtual ICollection<FidelityMarketingContent> FidelityMarketingContents { get; set; } = new List<FidelityMarketingContent>();

    public virtual ICollection<FidelitySurvey> FidelitySurveys { get; set; } = new List<FidelitySurvey>();

    public virtual ICollection<LegalDocument> LegalDocuments { get; set; } = new List<LegalDocument>();

    public virtual Medium? Logo { get; set; }

    public virtual ICollection<Shop> Shops { get; set; } = new List<Shop>();

    public virtual ICollection<Recipe> Recipes { get; set; } = new List<Recipe>();
}
