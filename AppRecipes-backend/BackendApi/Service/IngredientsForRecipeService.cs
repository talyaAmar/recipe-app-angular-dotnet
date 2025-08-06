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
    public class IngredientsForRecipeService : IIngredientsForResipeService
    {
        public readonly IIngredientsForRecipeRepository _IngredientsForResipeRepository;

        public IngredientsForRecipeService(IIngredientsForRecipeRepository ingredientsForRecipeRepository)
        {
            _IngredientsForResipeRepository = ingredientsForRecipeRepository;   
        }

        public List<IngredientsForRecipe> AddIngredient(int id, Dictionary<int, string> intIngredient)
        {
           return  _IngredientsForResipeRepository.AddIngredient(id, intIngredient);
          
        }

        public List<IngredientsForRecipe> GetIngredientRecipe(int id)
        {
           return _IngredientsForResipeRepository.GetIngredientRecipe(id);  
        }
    }
}
