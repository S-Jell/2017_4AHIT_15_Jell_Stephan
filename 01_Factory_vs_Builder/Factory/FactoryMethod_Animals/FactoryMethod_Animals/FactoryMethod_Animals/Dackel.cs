using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_Animals
{
    class Dackel:IDog
    {
        public void walk()
        {
            Console.WriteLine("Dackel is walking");
        }
        public void run()
        {
            Console.WriteLine("Dackel is running");
        }
        public void eat()
        {
            Console.WriteLine("Dackel is eating");
        }
    }
}
