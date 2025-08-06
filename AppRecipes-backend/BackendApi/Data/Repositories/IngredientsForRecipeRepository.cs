using Core.Reposetories;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webApi.Entities;

namespace Data.Repositories
{
    public class IngredientsForRecipeRepository : IIngredientsForRecipeRepository
    {
        DataContext _context;
        public IngredientsForRecipeRepository(DataContext context)
        {
            _context = context; 
        }

        public List<IngredientsForRecipe> AddIngredient(int recipeId, Dictionary<int, string> intIngredient)
        {
            var addedIngredients = new List<IngredientsForRecipe>();

            foreach (var item in intIngredient)
            {
                var ingredient = new IngredientsForRecipe
                {
                    IngredientCode = item.Key,
                    RecipeCode = recipeId,
                    Amount = item.Value
                };

                _context.IngredientsForRecipes.Add(ingredient);
                addedIngredients.Add(ingredient);
            }

            _context.SaveChanges();

            return addedIngredients;

        }

        //public List<IngredientsForRecipe> GetIngredientRecipe(int id)
        //{
        //    var listCodes = _context.IngredientsForRecipes
        //  .Where(x => x.RecipeCode == id)
        //  .Select(x => x.IngredientCode).ToList();
        //    //var ingredients = _context.IngredientsForRecipes
        //    //     .Where(i => listCodes.Contains(i.Code))
        //    //     .ToList();
        //    return listCodes;
        //}
        public List<IngredientsForRecipe> GetIngredientRecipe(int recipeId)
        {
            return _context.IngredientsForRecipes
                .Where(x => x.RecipeCode == recipeId)
                .ToList();
        }
    }
}
