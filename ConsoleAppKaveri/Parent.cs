using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppKaveri
{
    class Parent
    {
        protected int x, y, z;
        public void Add()
        {
            x = 45;
            y = 46;
            z = x + y;
            Console.WriteLine("Add is:" + z);  // add res
        }

        public void Sub()
        {
            x = 45;
            y = 46;
            z = x - y;
            Console.WriteLine("Sub is:" + z);  // sub res
        }
    }

    class Child : Parent

    // right hand > parent , left hand --> child
    {
        public void Mul()
        {
            Add();
            Sub();
            x = 45;
            y = 46;
            z = x * y;
            Console.WriteLine("Mul is:" + z);  // Mul res
        }

        public void Div()
        {
            x = 45;
            y = 46;
            z = x / y;
            Console.WriteLine("Div is:" + z);  // Div res
        }
    }

    class Child1 : Parent

    // right hand > parent , left hand --> child
    {
        public void Mul()
        {
            Add();
            Sub();
            x = 45;
            y = 46;
            z = x * y;
            Console.WriteLine("Mul is:" + z);  // Mul res
        }

        public void Div()
        {
            x = 45;
            y = 46;
            z = x / y;
            Console.WriteLine("Div is:" + z);  // Div res
        }
    }
}
