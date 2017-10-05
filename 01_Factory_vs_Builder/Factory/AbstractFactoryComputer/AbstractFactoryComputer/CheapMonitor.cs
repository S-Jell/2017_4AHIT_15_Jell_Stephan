using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryComputer
{
    class CheapMonitor:IMonitor
    {
        public void show()
        {
            Console.WriteLine("Cheap Monitor");
        }
    }
}
