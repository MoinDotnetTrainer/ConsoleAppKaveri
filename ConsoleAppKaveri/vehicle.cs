using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppKaveri
{
    abstract class vehicle
    {
        public abstract void Break();
        public abstract void Accele();
    }

    class twoWheeler : vehicle
    {
        public override void Break()
        {
            Console.WriteLine("two wheeler break details");
        }
        public override void Accele()
        {
            Console.WriteLine("two wheeler accele details");
        }
    }

    class FourWheel : vehicle
    {
        public override void Break()
        {
            Console.WriteLine("4 wheeler break details");
        }
        public override void Accele()
        {
            Console.WriteLine("4 wheeler accele details");
        }
    }
}
