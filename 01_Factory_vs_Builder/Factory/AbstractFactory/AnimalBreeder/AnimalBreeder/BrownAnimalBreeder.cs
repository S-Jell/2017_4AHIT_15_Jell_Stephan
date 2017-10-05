using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalBreeder
{
    class BrownAnimalBreeder:IAnimalBreeder
    {
        public IDog breedDog()
        {
            return new BrownDog();
        }
        public IChicken breedChicken()
        {
            return new BrownChicken();
        }
    }
}
