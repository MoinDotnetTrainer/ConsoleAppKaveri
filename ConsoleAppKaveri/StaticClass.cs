using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppKaveri
{
    static class StaticClass
    {
        static StaticClass()
        {
            Console.WriteLine("This is a static constructor in a static class.");
        }   
        public static void StaticMethod()
        {
            Console.WriteLine("This is a static method in a static class.");
        }

        public static int test() {
            return 1;
        }

 
    }
}
