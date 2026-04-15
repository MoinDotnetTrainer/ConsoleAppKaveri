using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppKaveri
{
    class Std
    {
        public int StdID { get; set; }
        public string Name { get; set; }
    }
    internal class genColl
    {
        public void List()
        {
            List<string> list = new List<string>();
            list.Add("Hi");
            list.Add("kjk");
            list.Add("dsfdg");
            list.Add("fdggfh");
            list.Add("df");
            list.Add("gfhg");
            list.Add("gfh");
            list.Remove("Hi");
            list.RemoveAt(3);
            list.Insert(2, "New val");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            List<int> intval = new List<int>();
            intval.Add(325);
            intval.Add(234);
            intval.Add(43);
            intval.Add(36725);
            intval.Add(78);
            intval.Add(76);

        }

        public void StoreStd()
        {
            //Std std = new Std();
            //std.StdID = 1;
            //std.Name = "Kaveri";

            List<Std> std = new List<Std>();
            std.Add(new Std { StdID = 1, Name = "Kaveri" });
            std.Add(new Std { StdID = 2, Name = "Moin" });
            std.Add(new Std { StdID = 3, Name = "test" });
            std.Add(new Std { StdID = 4, Name = "xyz" });
            foreach (var item in std)
            {
                Console.WriteLine($"Stdid is {item.StdID} and name is {item.Name}");
            }
        }
    }
}
