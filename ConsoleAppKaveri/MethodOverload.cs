using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppKaveri
{
    class MethodOverload
    {
        public void M1() {
            Console.WriteLine("task 1");
        }
        public int M1(int x)
        {
            Console.WriteLine("task 2");
            return 1;
        }
        public void M1(string x)
        {
            Console.WriteLine("task 3");
        }
        public void M1(int x , int y)
        {
            Console.WriteLine("task 4");
        }
        public void M1(int x, string y)
        {
            Console.WriteLine("task 5");
        }
        public void M1(string x, int y)
        {
            Console.WriteLine("task 6");
        }
    }
}
