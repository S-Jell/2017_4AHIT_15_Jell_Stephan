using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory_Fans
{
    class FanFactory:IFanFactory
    {
        public IFan CreateFan(Fantype type)
        {
            switch(type)
            {
                case Fantype.TableFan:
                    return new TableFan();
                    break;
                case Fantype.CeilingFan:
                    return new CeilingFan();
                    break;
                case Fantype.ExhaustFan:
                    return new ExhaustFan();
                    break;
                default:
                    return new TableFan();
                    break;
            }
        }
    }
}
