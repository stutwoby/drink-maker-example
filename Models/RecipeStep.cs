using System;

namespace Red_River.Models
{
    public class RecipeStep
    {
        public int Order { get; set; }

        public string Text { get; set; }

        public TimeSpan Time { get; set; }
    }
}