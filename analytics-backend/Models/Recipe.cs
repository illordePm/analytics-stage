using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class Recipe
{
    public int Id { get; set; }

    public bool IsValid { get; set; }

    public decimal? ProducedQuantity { get; set; }

    public int? ProducedMeasUnitId { get; set; }

    public int? RecipeCategoryId { get; set; }

    public int? RecipeSeasonId { get; set; }

    public int? RecipeClassId { get; set; }

    public int? RecipeTypeId { get; set; }

    public int? RecipeProvenanceId { get; set; }

    public DateTime CreationTime { get; set; }

    public string? Creator { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public string? LastModifier { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public decimal? AdditionalCost { get; set; }

    public virtual MeasUnit? ProducedMeasUnit { get; set; }

    public virtual RecipeCategory? RecipeCategory { get; set; }

    public virtual RecipeClass? RecipeClass { get; set; }

    public virtual ICollection<RecipeIngredient> RecipeIngredientRecipes { get; set; } = new List<RecipeIngredient>();

    public virtual ICollection<RecipeIngredient> RecipeIngredientReferenceRecipes { get; set; } = new List<RecipeIngredient>();

    public virtual ICollection<RecipeIngredientsFlat> RecipeIngredientsFlats { get; set; } = new List<RecipeIngredientsFlat>();

    public virtual RecipeProvenance? RecipeProvenance { get; set; }

    public virtual RecipeSeason? RecipeSeason { get; set; }

    public virtual RecipeType? RecipeType { get; set; }

    public virtual ICollection<SaleArticleLink> SaleArticleLinks { get; set; } = new List<SaleArticleLink>();

    public virtual ICollection<SaleArticleLinksHistory> SaleArticleLinksHistoryNewRecipes { get; set; } = new List<SaleArticleLinksHistory>();

    public virtual ICollection<SaleArticleLinksHistory> SaleArticleLinksHistoryOldRecipes { get; set; } = new List<SaleArticleLinksHistory>();

    public virtual ICollection<Brand> Brands { get; set; } = new List<Brand>();
}
