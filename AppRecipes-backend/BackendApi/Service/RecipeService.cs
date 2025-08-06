using Core.Reposetories;
using Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webApi.Entities;

namespace Service
{
    public class RecipeService: IRecipeService
    {
        public readonly IRecipeRepository _recipeRepository;

        public RecipeService(IRecipeRepository recipeRepository)
        {
            _recipeRepository = recipeRepository;
        }

        public Recipe AddRecipe(Recipe recipe)
        {
         return _recipeRepository.AddRecipe(recipe);
        }

        public Recipe GetByCode(int code)
        {
            return _recipeRepository.GetByCode(code);
        }

        public List<Recipe> GetRecipes()
        {
           return _recipeRepository.GetRecipes();   
        }
    }
}
