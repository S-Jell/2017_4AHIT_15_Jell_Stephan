using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternComputer
{
    class CheapHardDisk:IHardDisk
    {
        public string show()
        {
            return "Cheap HardDisk";
        }
    }
}
