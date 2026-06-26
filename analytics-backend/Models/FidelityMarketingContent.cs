using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class FidelityMarketingContent
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public DateOnly StartDate { get; set; }

    public TimeOnly StartTime { get; set; }

    public DateOnly EndDate { get; set; }

    public TimeOnly EndTime { get; set; }

    public string Weekdays { get; set; } = null!;

    public int? OrderNum { get; set; }

    public bool IsActive { get; set; }

    public string? Title { get; set; }

    public string? TextSection { get; set; }

    public int ImageMediaId { get; set; }

    public string? LinkUrl { get; set; }

    public DateTime CreationTime { get; set; }

    public string? Creator { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public string? LastModifier { get; set; }

    public int BrandId { get; set; }

    public virtual Brand Brand { get; set; } = null!;

    public virtual ICollection<FidelityMarketingContentsLang> FidelityMarketingContentsLangs { get; set; } = new List<FidelityMarketingContentsLang>();

    public virtual Medium ImageMedia { get; set; } = null!;
}
