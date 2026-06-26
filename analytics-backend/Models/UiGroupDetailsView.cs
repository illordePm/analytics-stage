using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class UiGroupDetailsView
{
    public int? Id { get; set; }

    public int? UiGroupId { get; set; }

    public int? ChildArticleId { get; set; }

    public int? ChildUiGroupId { get; set; }

    public int? OrderNumber { get; set; }

    public string? ValidForServiceTypes { get; set; }
}
