using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppKaveri
{
    internal class genMethod
    {
        public void test(int x, int y)
        {  // data type as an argument
            Console.WriteLine(x);
            Console.WriteLine(y);
        }

        //generic method which takes type as an argment and this type passed dunamicc during the call

        public void Mymethod<type1>(type1 x) {  // type1 can be any type , during
            Console.WriteLine(x);
        }

    }
}
