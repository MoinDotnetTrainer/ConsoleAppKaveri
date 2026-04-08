using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppKaveri
{
    internal class datatypes
    {
        public void DtExample()
        {
            // integer 0-9
            //byte , sbyte ,short , ushort , int ,uint,long,ulong
            //1,2,4,8 bytes of memory
            // 1 byte = 8 bit --> 0-255 
            byte b = 200;  // unsigned
            byte b1 = 0;
            byte b2 = 45;
            byte b3 = 255;

            // signed +- , Unsigned + 
            sbyte sb = -128; // signed --> -128 + 127
            sbyte sb1 = 127;

            // floating 0.00
            // float , double ,decimal
            float f = 45.45f; //4 8 16
            double d = 45.56;
            decimal dm = 56.56m;

            // bool T F
            bool status = true;

            char c = 'A';
            string str = "Hello world";

            // other categories
            // var dynamic & object

            //compiler time
            var v = 45;
            v = 56;
            v = 67;

            var v1 = "test";
            var v2 = true;
            var v3 = 45.56;
            var v4 = 'A';


            // runtime, value type
            dynamic d1 = 45;
            d1 = "testing";
            dynamic d2 = "test";
            dynamic d3 = true;
            dynamic d4 = 45.56;
            dynamic d5 = 'A';
            dynamic res = d1 + d4;


            //ref type
            object o1 = 45;
            object o2 = "test";
            object o3 = true;
            object o4 = 45;
            object o5 = 'A';

            object result = (int)o1 + (int)o4;
            // ref to value type
            // A+b;
            //1+1;

            // type

            // convertion technique & parsing techniques


        }

        public void Convertion()
        {
            /*Console.WriteLine("Enter Ur Name..");
            string name = Console.ReadLine();  // accepts input from keyboard
            Console.WriteLine("name is :"+name);

            Console.WriteLine("Enter ur Age");
            byte age =Convert.ToByte( Console.ReadLine()); // 0-255 100
            Console.WriteLine("My Age is:"+age);

            Console.WriteLine("Enter ur Rollno");
            int Rollno = Convert.ToInt32(Console.ReadLine()); // 0-255 100
            Console.WriteLine("My rollno is:" + Rollno);

            // int sbyte uint, long 
            //--> 255 

            Console.WriteLine("Enter ur Age1");
            byte age1 = byte.Parse(Console.ReadLine()); // 0-255 100
            Console.WriteLine("My Age is:" + age1);

            Console.WriteLine("Enter ur Rollno1");
            int Rollno1 = int.Parse(Console.ReadLine()); // 0-255 100
            Console.WriteLine("My rollno is:" + Rollno1);
            */

            //string str = null;
            //int myres = Convert.ToInt32(str); //  0
            //int myres1 = int.Parse(str);//  run time error
            //Console.WriteLine(myres);
            //Console.WriteLine(myres1);

            // what is Nullable
            // value type datatype & ref type datatype
            // fixed memory
            // int byte short ,float 
            // unfix , arrays , string object

            //int? number = null;

            //// number nullable --> so that i can take null value
            //string mystring = null;

            //int[] MyNumber = { 34, 4, 56, 766 };
            //Console.WriteLine(MyNumber[0]);

            //string[] mynames = { "hi","hello","test","welcome"};
        }
    }
}
