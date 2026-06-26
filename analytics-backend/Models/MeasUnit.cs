using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class MeasUnit
{
    public int Id { get; set; }

    public DateTime CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Creator { get; set; }

    public string? LastModifier { get; set; }

    public virtual ICollection<Article> ArticleMeasUnits { get; set; } = new List<Article>();

    public virtual ICollection<Article> ArticleWeightMeasUnits { get; set; } = new List<Article>();

    public virtual ICollection<ArticlesMeasUnitsConversionFactor> ArticlesMeasUnitsConversionFactors { get; set; } = new List<ArticlesMeasUnitsConversionFactor>();

    public virtual ICollection<DocumentRow> DocumentRows { get; set; } = new List<DocumentRow>();

    public virtual ICollection<MeasUnitsConversion> MeasUnitsConversionFromMeasUnits { get; set; } = new List<MeasUnitsConversion>();

    public virtual ICollection<MeasUnitsConversion> MeasUnitsConversionToMeasUnits { get; set; } = new List<MeasUnitsConversion>();

    public virtual ICollection<PurchasePriceListDetail> PurchasePriceListDetailMeasUnits { get; set; } = new List<PurchasePriceListDetail>();

    public virtual ICollection<PurchasePriceListDetail> PurchasePriceListDetailOrderMeasUnits { get; set; } = new List<PurchasePriceListDetail>();

    public virtual ICollection<RecipeIngredient> RecipeIngredientMeasUnits { get; set; } = new List<RecipeIngredient>();

    public virtual ICollection<RecipeIngredient> RecipeIngredientReferencedMeasUnits { get; set; } = new List<RecipeIngredient>();

    public virtual ICollection<RecipeIngredientsFlat> RecipeIngredientsFlats { get; set; } = new List<RecipeIngredientsFlat>();

    public virtual ICollection<Recipe> Recipes { get; set; } = new List<Recipe>();

    public virtual ICollection<SaleRow> SaleRows { get; set; } = new List<SaleRow>();
}
