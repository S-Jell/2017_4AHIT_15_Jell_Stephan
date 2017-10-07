using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternComputer
{
    class MemoryComputerBuilder:ComputerBuilder
    {
        private Computer _computer = new Computer();
        public override void BuildRam()
        {
            _computer.Add(new CheapRam().show());
        }
        public override void BuildHardDisk()
        {
            _computer.Add(new ExpensiveHardDisk().show());
        }
        public override void BuildMonitor()
        {
            _computer.Add(new CheapMonitor().show());
        }
        public override void BuildProcessor()
        {
            _computer.Add(new CheapProcessor().show());
        }
        public override Computer GetResult()
        {
            return _computer;
        }
    }
}
