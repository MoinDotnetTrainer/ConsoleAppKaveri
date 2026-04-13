using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppKaveri
{
    internal class Prop
    {
        private int x;

        public int x_
        {
            get { return x; }
            set
            {
                if (value > 50)
                {
                    throw new ArgumentOutOfRangeException("Value cannot be more than 50");
                }

                else
                {
                    x = value;
                }
            }
        }

        private int y;

        public int y_
        {
            get { return y; }
            set
            {
                if (value > 50)
                {
                    throw new ArgumentOutOfRangeException("Value cannot be more than 50");
                }

                else
                {
                    y = value;
                }
            }
        }


        public void Add()
        {

            int z = x + y; // add
            Console.WriteLine("Add:" + z);
        }


    }
}
