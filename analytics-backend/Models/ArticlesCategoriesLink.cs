using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class ArticlesCategoriesLink
{
    public int ArticleId { get; set; }

    public int AssignedCategoryId { get; set; }

    public int AssignedCategoryRootId { get; set; }

    public virtual Article Article { get; set; } = null!;

    public virtual ArticlesCategory AssignedCategory { get; set; } = null!;

    public virtual ArticlesCategory AssignedCategoryRoot { get; set; } = null!;
}
