using Core.Reposetories;
using Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webApi.Entities;

namespace webApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngredientsForRecipeController : ControllerBase
    {
        private IIngredientsForResipeService _ingredientsForResipeService;
        
        public IngredientsForRecipeController(IIngredientsForResipeService ingredientsForResipeService)
        {
            _ingredientsForResipeService = ingredientsForResipeService;
        }

        [HttpPost("{id}")]
        public ActionResult<List<IngredientsForRecipe>> Post( int id, [FromBody] Dictionary<int, string> intIngredient)
        {
            return _ingredientsForResipeService.AddIngredient(id, intIngredient);

        }

            [HttpGet("{id}")]
            public ActionResult<List<IngredientsForRecipe>> Get( int id)
        {
            return _ingredientsForResipeService.GetIngredientRecipe(id);
        }
  

    }
}
