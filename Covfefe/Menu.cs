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


        public void Buy()
        {
            Console.WriteLine("Ok! Some " + Name + ". Anything else?\n");
        }
    }
}
