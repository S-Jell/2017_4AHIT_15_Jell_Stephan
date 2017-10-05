using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalBreeder
{
    class WhiteDog:IDog
    {
         public void walk()
        {
            Console.WriteLine("White Dog is walking");
        }
        public void bark()
        {
            Console.WriteLine("White dog is barking");
        }

    }
}
