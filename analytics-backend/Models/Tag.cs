using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class Tag
{
    public int Id { get; set; }

    public string? Value { get; set; }

    public DateTime CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Creator { get; set; }

    public string? LastModifier { get; set; }

    public virtual ICollection<ArticlesKioskDatum> ArticlesKioskData { get; set; } = new List<ArticlesKioskDatum>();

    public virtual ICollection<KioskUiGroup> KioskUiGroups { get; set; } = new List<KioskUiGroup>();

    public virtual ICollection<TagsLang> TagsLangs { get; set; } = new List<TagsLang>();
}
