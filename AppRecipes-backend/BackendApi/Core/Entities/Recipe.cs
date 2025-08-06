using System;
using System.Collections.Generic;

namespace webApi.Entities;

public partial class Recipe
{
    public int Code { get; set; }

    public string? Name { get; set; }

    public string? Desc { get; set; }

    public string? Image { get; set; }

    public int? DifficultLevel { get; set; }

    public int? Time { get; set; }

    public int? Quantity { get; set; }

    public string? Instructions { get; set; }

    public int? UserCode { get; set; }

    public virtual ICollection<IngredientsForRecipe> IngredientsForRecipes { get; set; } = new List<IngredientsForRecipe>();

    public virtual User? UserCodeNavigation { get; set; }
}
