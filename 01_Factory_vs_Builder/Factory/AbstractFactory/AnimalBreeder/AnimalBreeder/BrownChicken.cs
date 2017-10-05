using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalBreeder
{
    class BrownChicken:IChicken
    {
        public void walk()
        {
            Console.WriteLine("Brown chicken is walking");
        }
        public void gock()
        {
            Console.WriteLine("Brown chicken is gocking");
        }
    }
}
