using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppKaveri
{
    static class MyClass
    {
        public static void Add(this Demo obj) {
            Console.WriteLine("demo class Add method from myclass");
        }

        public static void Sub(this Demo obj)
        {
            Console.WriteLine("demo class Aub method from myclass");
        }
    }
}
