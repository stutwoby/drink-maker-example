using System.Collections.Generic;

namespace Red_River.Models
{
    public class Recipe
    {
        public IEnumerable<RecipeStep> Steps { get; set; }
    }
}