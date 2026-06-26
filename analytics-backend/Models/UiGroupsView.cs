using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class UiGroupsView
{
    public int? Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? ReadableName { get; set; }

    public string? Description { get; set; }

    public int? MediaId { get; set; }

    public int? TileTemplateId { get; set; }

    public int? GroupByTagId { get; set; }
}
