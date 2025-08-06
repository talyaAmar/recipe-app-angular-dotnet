using Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webApi.Entities;

namespace webApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
       private readonly IRecipeService _recipeService;

        public RecipeController(IRecipeService recipeService)
        {
            _recipeService = recipeService;
        }


        [HttpGet("{code}")]
        public ActionResult<Recipe> Get(int code)
        {
            return _recipeService.GetByCode(code);
        }
        [HttpGet]
        public ActionResult <List<Recipe>> GetAll()
        {
            return _recipeService.GetRecipes();
        }

        [HttpPost]
        public ActionResult<Recipe> Post([FromBody] Recipe recipe)
        {
            return _recipeService.AddRecipe(recipe);
          
        }



    }
}