using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webApi.Entities;

namespace Core.Services
{
    public interface IIngredientsForResipeService
    {
        List<IngredientsForRecipe> GetIngredientRecipe(int id);
        List<IngredientsForRecipe> AddIngredient(int id, Dictionary<int, string> intIngredient);
    }
}
