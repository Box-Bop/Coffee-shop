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
        public double Buy(double money)
        {
            double remmoney = money - Cost;

            if (remmoney > 0)
            {
                Console.WriteLine("Ok, that'll be a " + Name);
                Console.WriteLine("You have " + remmoney + " left on your balance.");
                Console.ReadLine();
            }
            return remmoney;
        }
    }
}
