using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppKaveri
{
    internal class MultipleReturnType
    {
        public void T1()
        {
            Console.WriteLine("t1");
        }

        public int T2(int x)
        {
            return x;
        }

        public (int, string) T3(int x, string y)
        {
            return (x, y);
        }

        public void T4(int x, int y, out int Add, out int Sub) {
            Add = x + y;
            Sub = x - y;
        }
    }
}
