using Microsoft.AspNetCore.SignalR;
using Red_River.Enums;
using Red_River.Models;
using Red_River.Models.Drinks;
using Red_River.SignalRHubs;
using System.Threading.Tasks;

namespace Red_River.Services
{
    public class DrinkMakerService : IDrinkMakerService
    {
        private IHubContext<DrinkHub> _drinkHubContext;
        private readonly string MakeDrinkHubMethodName = "makeDrink";

        public DrinkMakerService(IHubContext<DrinkHub> drinkHubContext)
        {
            _drinkHubContext = drinkHubContext;
        }

        public Recipe GetRecipe(DrinkTypeEnum drinkType)
        {
            IDrink drink;

            switch (drinkType)
            {
                case DrinkTypeEnum.Tea:
                    drink = new TeaDrink();
                    break;

                case DrinkTypeEnum.Coffee:
                    drink = new CoffeeDrink();
                    break;

                case DrinkTypeEnum.HotChocolate:
                    drink = new HotChocolateDrink();
                    break;

                default:
                    drink = new CoffeeDrink();
                    break;
            }
            return drink.Recipe;
        }

        public async Task<bool> MakeDrink(Recipe recipe)
        {
            foreach (var step in recipe.Steps)
            {
                await _drinkHubContext.Clients.All.SendAsync(MakeDrinkHubMethodName, step.Text);
                System.Threading.Thread.Sleep(step.Time);
            }
            return await Task.FromResult(true);
        }
    }
}