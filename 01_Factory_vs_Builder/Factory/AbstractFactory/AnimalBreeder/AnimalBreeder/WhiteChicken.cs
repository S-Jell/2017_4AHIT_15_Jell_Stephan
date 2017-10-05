using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalBreeder
{
    class WhiteChicken:IChicken
    {
        public void walk()
        {
            Console.WriteLine("White chicken is walking");
        }
        public void gock()
        {
            Console.WriteLine("White chicken is gocking");
        }
    }
}
