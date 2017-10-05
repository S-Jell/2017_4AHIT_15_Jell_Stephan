using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalBreeder
{
    class WhiteAnimalBreeder:IAnimalBreeder
    {
        public IDog breedDog()
        {
            return new WhiteDog();
        }
        public IChicken breedChicken()
        {
            return new WhiteChicken();
        }
    }
}
