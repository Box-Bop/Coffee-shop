using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covfefe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome!\nWhat would you like to order?\n");
            bool start = true;
            while (start == true)
            {
                var menu = new Menu();
                Console.WriteLine("We have:\nHot chocolate (1)\nCoffee (2)\nEkspresso (3)");
                int dec = Convert.ToInt32(Console.ReadLine());

                if (dec == 1)
                {
                    menu.HotChocolate();
                    menu.Buy();
                }
                if (dec == 2)
                {
                    menu.Coffee();
                    menu.Buy();
                }
                if (dec == 3)
                {
                    menu.Ekspresso();
                    menu.Buy();
                }


            }

        }
    }
}
