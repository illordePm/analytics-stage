using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class TagsLang
{
    public int TagId { get; set; }

    public string LanguageCode { get; set; } = null!;

    public string? Value { get; set; }

    public virtual Tag Tag { get; set; } = null!;
}
