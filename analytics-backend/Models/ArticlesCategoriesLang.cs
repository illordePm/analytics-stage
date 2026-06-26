using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class ArticlesCategoriesLang
{
    public int CategoryId { get; set; }

    public string LanguageCode { get; set; } = null!;

    public string Name { get; set; } = null!;

    public virtual ArticlesCategory Category { get; set; } = null!;
}
