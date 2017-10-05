using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory_Fans
{
    class TableFan:IFan
    {
        public void switchOn()
        {
            Console.WriteLine("Table fan switched on");
        }
        public void switchOff()
        {
            Console.WriteLine("Table fan switched off");
        }
    }
}
