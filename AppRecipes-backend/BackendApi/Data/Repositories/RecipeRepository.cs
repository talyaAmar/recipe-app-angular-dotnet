using Core.Reposetories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webApi.Entities;

namespace Data.Repositories
{
    public class RecipeRepository : IRecipeRepository
    {
        DataContext _context;
        public RecipeRepository(DataContext context)
        {
            _context = context;
        }
        public Recipe AddRecipe(Recipe recipe)
        {
         _context.Recipes.Add(recipe);
            _context.SaveChanges();
            return recipe;  
        }

        public Recipe GetByCode(int code)
        {
           var r= _context.Recipes.FirstOrDefault(x => x.Code == code);
            return r;
        }

        public List<Recipe> GetRecipes()
        {
        return _context.Recipes.ToList();
        }
    }
}
