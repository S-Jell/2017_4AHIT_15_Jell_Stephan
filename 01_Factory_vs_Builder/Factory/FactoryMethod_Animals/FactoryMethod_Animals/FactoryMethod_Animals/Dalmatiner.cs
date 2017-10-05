using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_Animals
{
    class Dalmatiner:IDog
    {
        public void walk()
        {
            Console.WriteLine("Dalmatiner is walking");
        }
        public void run()
        {
            Console.WriteLine("Dalmatiner is running");
        }
        public void eat()
        {
            Console.WriteLine("Dalmatiner is eating");
        }
    }
}
