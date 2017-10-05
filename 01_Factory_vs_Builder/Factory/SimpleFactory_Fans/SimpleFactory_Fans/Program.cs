using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory_Fans
{
    class Program
    {
        static void Main(string[] args)
        {
            IFanFactory factory = new FanFactory();

            IFan ceiling_fan = factory.CreateFan(Fantype.CeilingFan);
            ceiling_fan.switchOn();
        }
    }
}
