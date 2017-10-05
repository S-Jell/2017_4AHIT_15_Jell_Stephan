using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryComputer
{
    interface ComputerFactory
    {
        IRam createRam();
        IProcessor createProcessor();
        IHardDisk createHardDisk();
        IMonitor createMonitor();
    }
}
