using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class Medium
{
    public int Id { get; set; }

    public int Type { get; set; }

    public string Url { get; set; } = null!;

    public bool IsPending { get; set; }

    public virtual ICollection<Article> Articles { get; set; } = new List<Article>();

    public virtual ICollection<ArticlesKioskDataLang> ArticlesKioskDataLangs { get; set; } = new List<ArticlesKioskDataLang>();

    public virtual ArticlesKioskDatum? ArticlesKioskDatumMedia { get; set; }

    public virtual ArticlesKioskDatum? ArticlesKioskDatumTileMedia { get; set; }

    public virtual ICollection<Brand> Brands { get; set; } = new List<Brand>();

    public virtual ICollection<CouponTemplate> CouponTemplates { get; set; } = new List<CouponTemplate>();

    public virtual ICollection<CouponTemplatesLang> CouponTemplatesLangs { get; set; } = new List<CouponTemplatesLang>();

    public virtual ICollection<FidelityMarketingContent> FidelityMarketingContents { get; set; } = new List<FidelityMarketingContent>();

    public virtual ICollection<FidelityMarketingContentsLang> FidelityMarketingContentsLangs { get; set; } = new List<FidelityMarketingContentsLang>();

    public virtual KioskLanguage? KioskLanguage { get; set; }

    public virtual ICollection<KioskMediaScheduleDetail> KioskMediaScheduleDetailTopBannerMedia { get; set; } = new List<KioskMediaScheduleDetail>();

    public virtual ICollection<KioskMediaScheduleDetail> KioskMediaScheduleDetailWelcomeMedia { get; set; } = new List<KioskMediaScheduleDetail>();

    public virtual ICollection<KioskMediaSchedule> KioskMediaScheduleTopBannerMedia { get; set; } = new List<KioskMediaSchedule>();

    public virtual ICollection<KioskMediaSchedule> KioskMediaScheduleWelcomeMedia { get; set; } = new List<KioskMediaSchedule>();

    public virtual KioskPayment? KioskPayment { get; set; }

    public virtual KioskServiceType? KioskServiceType { get; set; }

    public virtual ICollection<KioskUiGroupLang> KioskUiGroupLangs { get; set; } = new List<KioskUiGroupLang>();

    public virtual ICollection<KioskUiGroup> KioskUiGroups { get; set; } = new List<KioskUiGroup>();
}
