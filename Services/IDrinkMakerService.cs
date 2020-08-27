using Red_River.Enums;
using Red_River.Models;
using System.Threading.Tasks;

namespace Red_River.Services
{
    public interface IDrinkMakerService
    {
        Recipe GetRecipe(DrinkTypeEnum drinkType);

        Task<bool> MakeDrink(Recipe recipe);
    }
}