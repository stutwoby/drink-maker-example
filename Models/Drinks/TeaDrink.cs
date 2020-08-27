﻿using System;
using System.Collections.Generic;

namespace Red_River.Models.Drinks
{
    public class TeaDrink : IDrink
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
                        new RecipeStep{ Order=2, Text="Steep the water in the tea", Time=new TimeSpan(0, 0, 3)},
                        new RecipeStep{ Order=3, Text="Pour tea in the cup", Time=new TimeSpan(0, 0, 1)},
                        new RecipeStep{ Order=4, Text="Add Lemon", Time=new TimeSpan(0, 0, 1)}
                    }
                };
            }
        }
    }
}