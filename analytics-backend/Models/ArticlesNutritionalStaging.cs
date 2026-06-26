using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class ArticlesNutritionalStaging
{
    public int Id { get; set; }

    public string? ArticleCode { get; set; }

    public string? FoodTypes { get; set; }

    public string? Allergens { get; set; }

    public string? Ingredients { get; set; }

    public float? Kcal { get; set; }

    public float? Sodium { get; set; }

    public float? Fats { get; set; }

    public float? SaturatedFats { get; set; }

    public float? Carbohydrates { get; set; }

    public float? Sugars { get; set; }

    public float? Proteins { get; set; }
}
