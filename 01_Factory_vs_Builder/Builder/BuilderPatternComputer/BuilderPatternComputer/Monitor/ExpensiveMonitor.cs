using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternComputer
{
    class ExpensiveMonitor:IMonitor
    {
        public string show()
        {
            return "Expensive Monitor";
        }
    }
}
