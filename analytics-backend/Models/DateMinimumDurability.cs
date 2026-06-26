using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class DateMinimumDurability
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public string Description { get; set; } = null!;

    public virtual ICollection<RecipeIngredient> RecipeIngredients { get; set; } = new List<RecipeIngredient>();
}
