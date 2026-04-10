using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppKaveri
{
    internal class PulsarBike1
    {
        public virtual void Break() {
            Console.WriteLine("No disk");
        }
    }

    class PulsarBike2 : PulsarBike1
    {
        public override void Break()
        {
            Console.WriteLine("Disk break");
        }
    }
     class PulsarBike3 : PulsarBike1
    {
        public override void Break()
        {
            Console.WriteLine("Hydrolic Break");
        }
    }   
}
