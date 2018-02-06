using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covfefe
{
    class Coffee : Menu
    {
        public Coffee()
        {
            Cost = 1.3;
            Ingridients = "Coffee powder\nHot water";
            Type = "Hot drink";
            Name = "Generic coffee";
        }
        public override double Buy(double money)
        {
            Console.WriteLine("Definitely our most popular purchase here!");
            base.Buy(money);
            return money;
        }
    }
}
