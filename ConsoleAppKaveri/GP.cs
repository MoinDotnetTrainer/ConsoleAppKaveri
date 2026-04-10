using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppKaveri
{
    internal class GP
    {
        public int x, y, z;

    }
    class P : GP
    {
        public int a, b, c;
        public void testing()
        {
            x = 657;
        }
    }

    class C : P
    {
        public void test()
        {
            a = 56;
            x = 56;
        }
    }
}
