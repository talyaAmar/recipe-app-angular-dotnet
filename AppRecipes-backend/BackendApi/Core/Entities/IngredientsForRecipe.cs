using System;
using System.Collections.Generic;

namespace webApi.Entities;

public partial class IngredientsForRecipe
{
    public int Code { get; set; }

    public int? RecipeCode { get; set; }

    public int? IngredientCode { get; set; }

    public string? Amount { get; set; }

    public virtual Ingredient? IngredientCodeNavigation { get; set; }

    public virtual Recipe? RecipeCodeNavigation { get; set; }
}
