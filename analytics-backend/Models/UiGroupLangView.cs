using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class UiGroupLangView
{
    public int? UiGroupId { get; set; }

    public string? LanguageCode { get; set; }

    public string? ReadableName { get; set; }

    public string? Description { get; set; }

    public int? MediaId { get; set; }
}
