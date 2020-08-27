using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Red_River.Models.Drinks
{
    interface IDrink
    {
        public Recipe Recipe { get; }
    }
}
