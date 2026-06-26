using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class UpsellSetLink
{
    public int Id { get; set; }

    public int UpsellSetId { get; set; }

    public int? AssociatedArticleId { get; set; }

    public int? AssociatedPosId { get; set; }

    public virtual Article? AssociatedArticle { get; set; }

    public virtual Po? AssociatedPos { get; set; }

    public virtual UpsellSet UpsellSet { get; set; } = null!;
}
