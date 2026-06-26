using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class UpsellSetDetail
{
    public int Id { get; set; }

    public int UpsellSetId { get; set; }

    public int ChildArticleId { get; set; }

    public virtual Article ChildArticle { get; set; } = null!;

    public virtual UpsellSet UpsellSet { get; set; } = null!;
}
