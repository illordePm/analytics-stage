using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class KioskUiGroupLang
{
    public int KioskUiGroupId { get; set; }

    public string LanguageCode { get; set; } = null!;

    public string? ReadableName { get; set; }

    public string? Description { get; set; }

    public int? MediaId { get; set; }

    public virtual KioskUiGroup KioskUiGroup { get; set; } = null!;

    public virtual Medium? Media { get; set; }
}
