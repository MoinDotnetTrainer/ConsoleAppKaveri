using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppKaveri
{
    internal class Constr
    {
        // can we have  a static const
        static Constr()
        {
            Console.WriteLine("Default");
        }

        public Constr(int x)
        {
            Console.WriteLine("1 pm int cnstr");
        }
    }
}
