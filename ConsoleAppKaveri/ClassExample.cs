using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppKaveri
{
    class ClassExample
    {
        //methods
        public void test()
        {
            Console.WriteLine("Some result");
        }

        int x, y, z;  // data memeber

        // member function
        public void Add()
        {
            x = 45; y = 56;
            z = x + y;
            Console.WriteLine("Add is:" + z);
        }

        public void Sub()
        {
            x = 45; y = 56;
            z = x - y;
            Console.WriteLine("Sub is:" + z);
        }

        public void Mul(int x, int y)
        { // parameterized method
            z = x * y;
            Console.WriteLine("Mul is:" + z);
        }
        public void Div(int x, int y)   // 12,2
        { // parameterized method
            z = x / y;
            Console.WriteLine("Div is:" + z);
        }
        public void Ops(int x = 12, int y = 12)   // 12,2
        { // parameterized method
            z = x + y;
            Console.WriteLine("Ops is:" + z);
        }

        public void Cal(int x, params int[] y)   // 12,2
        { // parameterized method
            Console.WriteLine(x);
            foreach (var item in y)
            {
                Console.WriteLine(item);
            }
            // Console.WriteLine("Cal is:" + z);
        }


        public int Addition()
        {
            int x = 45, y = 45, z;
            z = x + y;
            Console.WriteLine("Additopn is :" + z);
            return z;
        }

    }

}
