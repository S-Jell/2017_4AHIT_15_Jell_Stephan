using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory_Fans
{
    enum Fantype
    {
        TableFan,
        CeilingFan,
        ExhaustFan
    }
    interface IFanFactory
    {
        IFan CreateFan(Fantype type);
    }
}
