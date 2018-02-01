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
