using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BuilderPatternComputer
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();

            ComputerBuilder expensive_builder = new ExpensiveComputerBuilder();
            ComputerBuilder cheap_builder = new CheapComputerBuilder();
            ComputerBuilder memory_builder = new MemoryComputerBuilder();

            Console.WriteLine("---------------------\nExpensive Computer\n---------------------");
            director.construct(expensive_builder);
            Computer expensive_computer = expensive_builder.GetResult();
            expensive_computer.Show();

            Console.WriteLine("---------------------\nCheap Computer\n---------------------");

            director.construct(cheap_builder);
            Computer cheap_computer = cheap_builder.GetResult();
            cheap_computer.Show();

            Console.WriteLine("---------------------\nMemory Computer\n---------------------");
            director.construct(memory_builder);
            Computer memory_computer = memory_builder.GetResult();
            memory_computer.Show();

            Console.ReadLine();
        }
    }
}
