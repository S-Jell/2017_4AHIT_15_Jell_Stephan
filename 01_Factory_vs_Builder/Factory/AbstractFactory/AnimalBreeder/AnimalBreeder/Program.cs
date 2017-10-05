using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalBreeder
{
    class Program
    {
        static void Main(string[] args)
        {
            IAnimalBreeder brownBreeder = new BrownAnimalBreeder();
            IAnimalBreeder whiteBreeder = new WhiteAnimalBreeder();

            IDog bDog = brownBreeder.breedDog();
            IChicken wChicken = whiteBreeder.breedChicken();

            bDog.bark();
            wChicken.gock();

            Console.ReadLine();
        }
    }
}
