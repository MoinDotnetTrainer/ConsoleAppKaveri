using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppKaveri
{
    class RBI
    {
        public void StaffData()
        {
            Console.WriteLine("this shows staff data");
        }

        public void CustomerData()
        {
            Console.WriteLine("this shows customer data");
        }

        public virtual void Withdraw()
        {
            Console.WriteLine("RBI withdraw Details");
        }
        public virtual void Deposit()
        {
            Console.WriteLine("RBI Deposit Details");
        }
    }

    class SBI : RBI
    {
        public override void Withdraw()
        {
            Console.WriteLine("SBI withdraw Details");
        }
        public override void Deposit()
        {
            Console.WriteLine("SBI Deposit Details");
        }
    }

    class Icici : RBI
    {
        public override void Withdraw()
        {
            Console.WriteLine("icici withdraw Details");
        }
        public override void Deposit()
        {
            Console.WriteLine("icici Deposit Details");
        }
    }
}
