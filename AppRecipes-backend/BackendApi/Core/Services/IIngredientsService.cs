using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webApi.Entities;

namespace Core.Services
{
    public interface IIngredientsService
    {
        public List<Ingredient> GetAllIngredients();
        public Ingredient AddIngredient(Ingredient ingredient);
    }
}
