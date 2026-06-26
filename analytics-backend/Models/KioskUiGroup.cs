using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class KioskUiGroup
{
    public int Id { get; set; }

    public string? ReadableName { get; set; }

    public string? Description { get; set; }

    public int? MediaId { get; set; }

    public int? TileTemplateId { get; set; }

    public DateTime CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public int? GroupByTagId { get; set; }

    public string? Creator { get; set; }

    public string? LastModifier { get; set; }

    public virtual Tag? GroupByTag { get; set; }

    public virtual ICollection<KioskUiGroupDetail> KioskUiGroupDetailChildKioskUiGroups { get; set; } = new List<KioskUiGroupDetail>();

    public virtual ICollection<KioskUiGroupDetail> KioskUiGroupDetailKioskUiGroups { get; set; } = new List<KioskUiGroupDetail>();

    public virtual ICollection<KioskUiGroupLang> KioskUiGroupLangs { get; set; } = new List<KioskUiGroupLang>();

    public virtual ICollection<KioskUiGroupLayoutsLink> KioskUiGroupLayoutsLinks { get; set; } = new List<KioskUiGroupLayoutsLink>();

    public virtual Medium? Media { get; set; }

    public virtual KioskUiTileTemplate? TileTemplate { get; set; }
}
