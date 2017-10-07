using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternComputer
{
    class Director
    {
        public void construct(ComputerBuilder builder)
        {
            builder.BuildHardDisk();
            builder.BuildMonitor();
            builder.BuildProcessor();
            builder.BuildRam();
        }
    }
}
