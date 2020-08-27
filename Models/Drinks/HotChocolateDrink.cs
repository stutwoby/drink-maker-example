using System;
using System.Collections.Generic;

namespace Red_River.Models.Drinks
{
    public class HotChocolateDrink : IDrink
    {
        public Recipe Recipe
        {
            get
            {
                return new Recipe()
                {
                    Steps = new List<RecipeStep>
                    {
                        // Actual timings not represented
                        new RecipeStep{ Order=1, Text="Boil some water", Time=new TimeSpan(0, 0, 1)},
                        new RecipeStep{ Order=2, Text="Add drinking chocolate powder to the water", Time=new TimeSpan(0, 0, 3)},
                        new RecipeStep{ Order=3, Text="Pour chocolate in the cup", Time=new TimeSpan(0, 0, 1)}
                    }
                };
            }
        }
    }
}