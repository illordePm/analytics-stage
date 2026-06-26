using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class RecipeIngredient
{
    public int Id { get; set; }

    public int RecipeId { get; set; }

    public int? ArticleId { get; set; }

    public int? ReferenceRecipeId { get; set; }

    public int MeasUnitId { get; set; }

    public decimal ConversionFactor { get; set; }

    public decimal Quantity { get; set; }

    public decimal? NetQuantity { get; set; }

    public decimal? ProductionSurplus { get; set; }

    public bool SurplusInPercentual { get; set; }

    public decimal? ReferencedQuantity { get; set; }

    public int? ReferencedMeasUnitId { get; set; }

    public bool DontUnload { get; set; }

    public int? OrderNum { get; set; }

    public int? DateMinimumDurabilityId { get; set; }

    public string? Notes { get; set; }

    public int? SubstArticleId { get; set; }

    public List<int>? SubstShopIds { get; set; }

    public virtual Article? Article { get; set; }

    public virtual DateMinimumDurability? DateMinimumDurability { get; set; }

    public virtual MeasUnit MeasUnit { get; set; } = null!;

    public virtual Recipe Recipe { get; set; } = null!;

    public virtual ICollection<RecipeIngredientsFlat> RecipeIngredientsFlats { get; set; } = new List<RecipeIngredientsFlat>();

    public virtual Recipe? ReferenceRecipe { get; set; }

    public virtual MeasUnit? ReferencedMeasUnit { get; set; }

    public virtual Article? SubstArticle { get; set; }
}
