using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class ArticlesCategory
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public int? ParentCategoryId { get; set; }

    public List<int> PathFromRoot { get; set; } = null!;

    public int CategoryType { get; set; }

    public DateTime CreationTime { get; set; }

    public string? Creator { get; set; }

    public bool IsMainCategory { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public string? LastModifier { get; set; }

    public string? Notes { get; set; }

    public virtual ICollection<ArticlesCategoriesLang> ArticlesCategoriesLangs { get; set; } = new List<ArticlesCategoriesLang>();

    public virtual ICollection<ArticlesCategoriesLink> ArticlesCategoriesLinkAssignedCategories { get; set; } = new List<ArticlesCategoriesLink>();

    public virtual ICollection<ArticlesCategoriesLink> ArticlesCategoriesLinkAssignedCategoryRoots { get; set; } = new List<ArticlesCategoriesLink>();

    public virtual ICollection<ArticlesCategory> InverseParentCategory { get; set; } = new List<ArticlesCategory>();

    public virtual ArticlesCategory? ParentCategory { get; set; }
}
