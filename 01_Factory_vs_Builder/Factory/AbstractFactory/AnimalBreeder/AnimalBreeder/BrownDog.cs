using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalBreeder
{
    class BrownDog:IDog
    {
        public void walk()
        {
            Console.WriteLine("Brown dog is walking");
        }
        public void bark()
        {
            Console.WriteLine("Brown dog is barking");
        }
    }
}
