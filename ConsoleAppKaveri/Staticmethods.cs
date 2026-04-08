using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppKaveri
{
    class Staticmethods
    {

        public Staticmethods()
        {   // constructor
            Console.WriteLine("Constr");
        }
        public void Add() { // non static
            int x = 3, y = 45, z;
            z = x + y;
            Console.WriteLine("Add is:"+z);
        }

        public static void Sub()  // static
        {
            int x = 3, y = 45, z;
            z = x - y;
            Console.WriteLine("Sub is:" + z);
        }
        public static void mul()  // static
        {
            int x = 3, y = 45, z;
            z = x * y;
            Console.WriteLine("mul is:" + z);
        }
    }
}
