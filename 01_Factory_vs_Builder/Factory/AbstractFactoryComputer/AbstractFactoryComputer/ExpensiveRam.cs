using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryComputer
{
    class ExpensiveRam:IRam
    {
        public void show()
        {
            Console.WriteLine("Expensive Ram");
        }
    }
}
