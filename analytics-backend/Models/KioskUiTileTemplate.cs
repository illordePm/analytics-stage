using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class KioskUiTileTemplate
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public bool ShowName { get; set; }

    public bool ShowDescription { get; set; }

    public bool ShowPrice { get; set; }

    public bool IsBackground { get; set; }

    public string Code { get; set; } = null!;

    public DateTime CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public string? CssClass { get; set; }

    public string? Creator { get; set; }

    public string? LastModifier { get; set; }

    public virtual ICollection<ArticlesKioskDatum> ArticlesKioskDatumArticlePageTileTemplates { get; set; } = new List<ArticlesKioskDatum>();

    public virtual ICollection<ArticlesKioskDatum> ArticlesKioskDatumTileTemplates { get; set; } = new List<ArticlesKioskDatum>();

    public virtual ICollection<KioskUiGroup> KioskUiGroups { get; set; } = new List<KioskUiGroup>();
}
