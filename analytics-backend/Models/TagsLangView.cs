using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class TagsLangView
{
    public int? TagId { get; set; }

    public string? LanguageCode { get; set; }

    public string? Value { get; set; }
}
