using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class FidelityMarketingContentsLang
{
    public int MarketingContentId { get; set; }

    public string LanguageCode { get; set; } = null!;

    public string? Title { get; set; }

    public string? TextSection { get; set; }

    public int? ImageMediaId { get; set; }

    public virtual Medium? ImageMedia { get; set; }

    public virtual FidelityMarketingContent MarketingContent { get; set; } = null!;
}
