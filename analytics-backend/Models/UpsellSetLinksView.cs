using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class UpsellSetLinksView
{
    public int? Id { get; set; }

    public int? UpsellSetId { get; set; }

    public int? AssociatedArticleId { get; set; }

    public int? AssociatedPosId { get; set; }
}
