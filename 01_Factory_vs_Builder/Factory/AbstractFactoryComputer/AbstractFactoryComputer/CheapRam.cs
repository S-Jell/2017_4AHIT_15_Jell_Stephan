using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryComputer
{
    class CheapRam:IRam
    {
        public void show()
        {
            Console.WriteLine("Cheap Ram");
        }
    }
}
