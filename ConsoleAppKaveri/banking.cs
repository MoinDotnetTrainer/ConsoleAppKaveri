using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppKaveri
{
    abstract class Banking
    {
        public abstract void Cheque();  //signature
        public abstract void CredeitcardDetailsd();
    }

    class HDFC : Banking
    {
        public override void Cheque()
        {
            Console.WriteLine("HDFC Cheque Details");
        }
        public override void CredeitcardDetailsd()
        {
            Console.WriteLine("HDFC Credit Card Details");
        }
    }   
}
