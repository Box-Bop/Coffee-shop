using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covfefe
{
    class Ekspresso : Menu
    {
        public Ekspresso()
        {
            Cost = 1;
            Ingridients = "1 coffee bean\nLava";
            Type = "Hot drink";
            Name = "Ekspresso";
        }

        public override double Buy(double money)
        {
            Console.WriteLine("Be careful with this, it's hot!");
            base.Buy(money);
            return money;
        }
    }
}
