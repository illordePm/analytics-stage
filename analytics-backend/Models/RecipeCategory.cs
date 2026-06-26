using System;
using System.Collections.Generic;

namespace analytics_backend.Models;

public partial class RecipeCategory
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public virtual ICollection<Recipe> Recipes { get; set; } = new List<Recipe>();
}
