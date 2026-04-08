using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppKaveri
{
    class ConstrChain
    {
        public ConstrChain() {
            Console.WriteLine("default");
        }
        public ConstrChain(int x) : this("23")
        {
            Console.WriteLine("1 pm int cnstr");
        }       

        public ConstrChain(int x, int y)  {
            Console.WriteLine("2 pm int cnstr");
        }

        public ConstrChain(string x)
        {
            Console.WriteLine("1 pm string cnstr");
        }
    }
}
