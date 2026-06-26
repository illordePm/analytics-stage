using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class UpsellSetDetailsView
{
    public int? Id { get; set; }

    public int? UpsellSetId { get; set; }

    public int? ChildArticleId { get; set; }
}
