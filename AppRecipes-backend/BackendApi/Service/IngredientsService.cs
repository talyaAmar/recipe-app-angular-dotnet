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
    public class IngredientsService : IIngredientsService
    {
        public readonly IIngredientsRepository _ingredientsRepository;

        public IngredientsService(IIngredientsRepository ingredientsRepository)
        {
            _ingredientsRepository = ingredientsRepository; 
        }
        public Ingredient AddIngredient(Ingredient ingredient)
        {
            return _ingredientsRepository.AddIngredient(ingredient);    
        }

        public List<Ingredient> GetAllIngredients()
        {
            return _ingredientsRepository.GetAllIngredients();  
        }
    }
}
