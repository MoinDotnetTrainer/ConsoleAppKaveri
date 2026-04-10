using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppKaveri
{
    class Classtest { 
    
    }
    interface Interface1
    {
        void Add();
    }
    interface Interface2
    {
        void Sub();
    }

    class Use : Classtest,Interface2, Interface1
    {
        public void Add()
        {
            int x = 45;
            int y = 46;
            int z = x + y;
            Console.WriteLine("Add is:" + z);  // add res
        }
        public void Sub()
        {
            int x = 45;
            int y = 46;
            int z = x - y;
            Console.WriteLine("Sub is:" + z);  // sub res
        }
    }
}
