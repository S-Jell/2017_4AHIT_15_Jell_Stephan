using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            IBreeder dackelbreeder = new DackelBreeder();
            IBreeder dalmatinerbreeder = new DalmatinerBreeder();

            IDog dackel = dackelbreeder.breedDog();
            IDog dalmatiner = dalmatinerbreeder.breedDog();

            dackel.eat();
            dalmatiner.run();

            Console.ReadLine();
        }
    }
}
