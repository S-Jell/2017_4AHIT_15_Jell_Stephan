using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalBreeder
{
    interface IAnimalBreeder
    {
        IDog breedDog();
        IChicken breedChicken();
    }
}
