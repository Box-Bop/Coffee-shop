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
            double money = 10;
            while (start == true)
            {
                Console.WriteLine("We have:\n2$ Hot chocolate (1)\n1.3$ Coffee (2)\n1$ Ekspresso (3)");
                int dec = Convert.ToInt32(Console.ReadLine());

                if (dec == 1)
                {
                    var b = new HotChocolate();
                    money = b.Buy(money);
                    start = false;
                }
                if (dec == 2)
                {
                    var b = new Coffee();
                    money = b.Buy(money);
                    start = false;
                }
                if (dec == 3)
                {
                    var b = new Ekspresso();
                    money = b.Buy(money);
                    start = false;
                }

            }
            while (start == false)
            {
                if (money < 0)
                {
                    Console.WriteLine("Sorry, but it seems that your card doesn't have enough balance to\n complete the purchase if you're going to buy this. ");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
                Console.WriteLine();
                Console.Clear();
                Console.WriteLine("Would you like anything else with that?\n\n2$ Hot chocolate (1)\n1.3$ Coffee (2)\n1$ Ekspresso (3)");

                int dec = Convert.ToInt32(Console.ReadLine());

                if (dec == 1)
                {
                    var b = new HotChocolate();
                    money = b.Buy(money);
                    start = false;
                }
                if (dec == 2)
                {
                    var b = new Coffee();
                    money = b.Buy(money);
                    start = false;
                }
                if (dec == 3)
                {
                    var b = new Ekspresso();
                    money = b.Buy(money);
                    start = false;
                }
            }
        }
    }
}
