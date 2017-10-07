using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternComputer
{
    abstract class ComputerBuilder
    {
        public abstract void BuildProcessor();
        public abstract void BuildRam();
        public abstract void BuildMonitor();
        public abstract void BuildHardDisk();

        public abstract Computer GetResult();

    }
}
