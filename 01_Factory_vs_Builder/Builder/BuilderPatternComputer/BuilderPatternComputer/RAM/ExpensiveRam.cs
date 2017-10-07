using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternComputer
{
    class ExpensiveRam:IRam
    {
        public string show()
        {
            return "Expensive Ram";
        }
    }
}
