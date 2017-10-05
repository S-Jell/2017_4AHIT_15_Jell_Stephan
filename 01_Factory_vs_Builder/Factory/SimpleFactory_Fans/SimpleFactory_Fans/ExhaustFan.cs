using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory_Fans
{
    class ExhaustFan:IFan
    {
        public void switchOn()
        {
            Console.WriteLine("Exhaust fan switched on");
        }
        public void switchOff()
        {
            Console.WriteLine("Exhaust fan switched off");
        }
    }
}
