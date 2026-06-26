using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class ArticlesLang
{
    public int ArticleId { get; set; }

    public string LanguageCode { get; set; } = null!;

    public string? PublicName { get; set; }

    public string? Description { get; set; }

    public string? LongDescription { get; set; }

    public string? BillDescription { get; set; }

    public string? Ingredients { get; set; }

    public virtual Article Article { get; set; } = null!;
}
