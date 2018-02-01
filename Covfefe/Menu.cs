using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covfefe
{
    class Menu
    {
        public double Cost;
        public string Ingridients;
        public string Type;
        public string Name;

        public void HotChocolate()
        {
            Cost = 2;
            Ingridients = "Hot milk\nCocoa power";
            Type = "Hot drink";
            Name = "Hot chocolate";
        }

        public void Coffee()
        {
            Cost = 1.3;
            Ingridients = "Coffee powder\nHot water";
            Type = "Hot drink";
            Name = "Generic coffee";
        }

        public void Ekspresso()
        {
            Cost = 1;
            Ingridients = "1 coffee bean\nLava";
            Type = "Hot drink";
            Name = "Ekspresso";
        }

        public void Buy()
        {
            Console.WriteLine("Ok! Some " + Name + ". Anything else?\n");
        }
    }
}
