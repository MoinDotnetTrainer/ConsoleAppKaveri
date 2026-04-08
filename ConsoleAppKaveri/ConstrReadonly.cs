using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppKaveri
{
    class ConstrReadonly
    {
        const int x = 89;
        readonly int y;
        public ConstrReadonly()
        {
            x = 456;
            y = 3;
        }

        public void T1()
        {
            y = 4;
        }
    }
}
