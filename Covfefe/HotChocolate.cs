using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covfefe
{
    class HotChocolate : Menu
    {
        public HotChocolate()
        {
            Cost = 2;
            Ingridients = "Hot milk\nCocoa power";
            Type = "Hot drink";
            Name = "Hot chocolate";
        }
    }
}
