using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternComputer
{
    class Computer
    {
        List<string> components = new List<string>();

        public void Add(string value)
        {
            components.Add(value);
        }
        public void Show()
        {
            foreach(string tmp in components)
            {
                Console.WriteLine(tmp);
            }
        }
    }
    
    
}
