using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class RecipeIngredientsFlat
{
    public int Id { get; set; }

    public int RecipeId { get; set; }

    public int? ShopId { get; set; }

    public int ArticleId { get; set; }

    public int? BaseArticleId { get; set; }

    public int MeasUnitId { get; set; }

    public decimal ConversionFactor { get; set; }

    public decimal Quantity { get; set; }

    public decimal SurplusQuantity { get; set; }

    public decimal UsedQuantity { get; set; }

    public int? IngredientId { get; set; }

    public int IngredientLevel { get; set; }

    public virtual Article Article { get; set; } = null!;

    public virtual Article? BaseArticle { get; set; }

    public virtual RecipeIngredient? Ingredient { get; set; }

    public virtual MeasUnit MeasUnit { get; set; } = null!;

    public virtual Recipe Recipe { get; set; } = null!;

    public virtual Shop? Shop { get; set; }
}
