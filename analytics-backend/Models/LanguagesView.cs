using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class LanguagesView
{
    public int? MediaId { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }
}
