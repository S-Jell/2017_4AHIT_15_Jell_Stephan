using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryComputer
{
    class CheapComputerFactory:ComputerFactory
    {
        public IRam createRam()
        {
            return new CheapRam();
        }
        public IProcessor createProcessor()
        {
            return new CheapProcessor();
        }
        public IMonitor createMonitor()
        {
            return new CheapMonitor();
        }
        public IHardDisk createHardDisk()
        {
            return new CheapHardDisk();
        }
    }
}
