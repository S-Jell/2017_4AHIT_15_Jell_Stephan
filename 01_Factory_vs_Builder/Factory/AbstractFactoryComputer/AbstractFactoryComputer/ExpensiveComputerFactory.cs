using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryComputer
{
    class ExpensiveComputerFactory:ComputerFactory
    {
        public IRam createRam()
        {
            return new ExpensiveRam();
        }
        public IProcessor createProcessor()
        {
            return new ExpensiveProcessor();
        }
        public IMonitor createMonitor()
        {
            return new ExpensiveMonitor();
        }
        public IHardDisk createHardDisk()
        {
            return new ExpensiveHardDisk();
        }
    }
}
