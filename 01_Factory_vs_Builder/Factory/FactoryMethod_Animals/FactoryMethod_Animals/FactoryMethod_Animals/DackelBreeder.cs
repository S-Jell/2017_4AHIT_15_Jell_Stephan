using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_Animals
{
    class DackelBreeder:IBreeder
    {
        public IDog breedDog()
        {
            return new Dackel();
        }
    }
}
