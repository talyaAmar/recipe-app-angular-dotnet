using Core.Reposetories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webApi.Entities;

namespace Data.Repositories
{
    public class IngredientsRepository : IIngredientsRepository
    {
        private readonly DataContext _context;
        public IngredientsRepository(DataContext context)
        {
            _context = context;
        }

        public Ingredient AddIngredient(Ingredient ingredient)
        {
           _context.Ingredients.Add(ingredient);
            _context.SaveChanges();
            return ingredient;

        }

        public List<Ingredient> GetAllIngredients()
        {
            return _context.Ingredients.ToList();
        }
    }
}


   
