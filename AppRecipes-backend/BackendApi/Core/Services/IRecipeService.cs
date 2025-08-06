using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webApi.Entities;

namespace Core.Services
{
    public interface IRecipeService
    {
        public List<Recipe> GetRecipes();
        public Recipe GetByCode(int code);
        public Recipe AddRecipe(Recipe recipe);   

    }
}
