using Microsoft.AspNetCore.Mvc;
using Red_River.Enums;
using Red_River.Services;
using System.Threading.Tasks;

namespace Red_River.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DrinkController : Controller
    {
        private IDrinkMakerService _drinkMakerService;

        public DrinkController(IDrinkMakerService drinkMakerService)
        {
            _drinkMakerService = drinkMakerService; ;
        }

        [HttpGet("make/{drinkType}")]
        public async Task<IActionResult> MakeDrink(DrinkTypeEnum drinkType)
        {
            var recipe = _drinkMakerService.GetRecipe(drinkType);

            await _drinkMakerService.MakeDrink(recipe);

            return Ok("Drink made!");
        }
    }
}