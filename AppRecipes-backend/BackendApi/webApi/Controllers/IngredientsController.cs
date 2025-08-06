using Core.Reposetories;
using Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webApi.Entities;

namespace webApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngredientsController : ControllerBase
    {
        private readonly IIngredientsService _ingredientsService;
        public IngredientsController(IIngredientsService ingredientsService)
        {
            _ingredientsService = ingredientsService;
        }

        [HttpPost]
            public ActionResult<Ingredient> Post([FromBody] Ingredient ingredient)
        {
            return _ingredientsService.AddIngredient(ingredient);   
        }
        [HttpGet]
        public ActionResult<List<Ingredient>> Get()
        {
            return _ingredientsService.GetAllIngredients(); 
        }
    }
}