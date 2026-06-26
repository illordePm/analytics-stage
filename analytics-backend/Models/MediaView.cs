using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class MediaView
{
    public int? Id { get; set; }

    public int? Type { get; set; }

    public string? Url { get; set; }
}
