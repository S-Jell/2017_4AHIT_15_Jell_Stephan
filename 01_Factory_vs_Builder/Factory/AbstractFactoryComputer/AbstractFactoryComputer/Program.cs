using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryComputer
{
    class Program
    {
        static void Main(string[] args)
        {
            ComputerFactory ExpensiveFactory = new ExpensiveComputerFactory();
            IRam eRam = ExpensiveFactory.createRam();
            IProcessor eProcessor = ExpensiveFactory.createProcessor();
            IMonitor eMonitor = ExpensiveFactory.createMonitor();
            IHardDisk eHardDisk = ExpensiveFactory.createHardDisk();

            eRam.show();

            Console.ReadLine();

        }
    }
}
