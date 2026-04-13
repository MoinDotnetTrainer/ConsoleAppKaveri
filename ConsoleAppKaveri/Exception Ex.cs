using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppKaveri
{
    internal class Exception_Ex
    {
        public void Div() {

        a:
            // unexpec
            try
            {
                int x, y, z;
                Console.WriteLine("Enter x");
                x = Convert.ToInt32(Console.ReadLine()); // input 

                Console.WriteLine("Enter y");
                y = Convert.ToInt32(Console.ReadLine());
                z = x / y; // div
                Console.WriteLine("Div:" + z);
            }
            catch (FormatException ex)
            {

                Console.WriteLine(ex.Message);
                goto a;
            }
            catch (DivideByZeroException ex)
            {

                Console.WriteLine(ex.Message);
                goto a;
            }

        }

        public void getLen() {
            string str = null;
            int len = str.Length; // 
            int[] arr = { 34};
            Console.WriteLine(arr[10]);
            Console.WriteLine(len);

        }
    }
}
