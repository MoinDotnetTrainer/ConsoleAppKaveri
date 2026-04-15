using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppKaveri
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Branch { get; set; }
        public int Age { get; set; }
    }
    internal class LINQExamples
    {
        public static void test()
        {
            List<Student> students = new List<Student>()
            {
                new Student { ID = 1001, Name = "Preety", Gender = "Female", Branch = "CSE", Age = 2 },
                new Student { ID = 1002, Name = "Snurag", Gender = "Male", Branch = "ETC", Age = 21  },
                new Student { ID = 1003, Name = "Pranaya", Gender = "Male", Branch = "CSE", Age = 21  },
                new Student { ID = 1004, Name = "Anurag", Gender = "Male", Branch = "CSE", Age = 20  },
                new Student { ID = 1005, Name = "Hina", Gender = "Female", Branch = "ETC", Age = 20 },
                new Student { ID = 1006, Name = "Priyanka", Gender = "Female", Branch = "CSE", Age = 21 },
                new Student { ID = 1007, Name = "santosh", Gender = "Male", Branch = "CSE", Age = 22  },
                new Student { ID = 1008, Name = "Tina", Gender = "Female", Branch = "CSE", Age = 20  },
                new Student { ID = 1009, Name = "Celina", Gender = "Female", Branch = "ETC", Age = 22 },
                new Student { ID = 1010, Name = "Sambit", Gender = "Male",Branch = "ETC", Age = 211 }
            };


            int[] arr = { 45, 5, 6, 76, 7, 8, 788, 9, 89, 34, 45, 5, 6, 576, 67, 67, 68, 78 };
            List<int> list = new List<int> { 46, 65, 76, 78, 89, 89, 9, 90, 09, 909, 090, 78978 };

            // LINQ common syntax to get data

            var result = from s in arr select s;

            var res1 = from s in arr where s < 50 select s;
            foreach (var item in res1)
            {
                //  Console.WriteLine(item);
            }


            var res = from s in students
                      where s.Age > 21
                      select s;

            var res2 = from s in students
                       select new
                       {
                           ID = s.ID,
                           Name = s.Name
                       };


            var res3 = from s in students
                       where s.ID == 1001 && s.Name == "kaveri"
                       select s;

            foreach (var item in res3)
            {
                //Console.WriteLine($"Id is {item.ID} name is {item.Name} gen is {item.Gender} branch is {item.Branch} age is {item.Age}");

            }
            var CountEx = (from s in arr select s).Count(x => x > 50);// va;ue
            //  Console.WriteLine(CountEx);

            var count1 = (from s in students select s).CountBy(x => x.Branch); //key & value
            foreach (var item in count1)
            {
                //Console.WriteLine(item.Key + "-" + item.Value);
            }

            var MaxEx = (from s in arr select s).Max();  //  vaue
                                                         // Console.WriteLine(MaxEx);

            var Max1 = (from s in students select s).MaxBy(x => x.Age);  // obj

            // Console.WriteLine(Max1.Name +"-"+Max1.Age);

            var Minex = (from s in arr select s).Min();  //  valure
            Console.WriteLine(Minex);

            var Min1 = (from s in students select s).MinBy(x => x.Age); //obj

            Console.WriteLine(Min1.Name + "-" + Min1.Age);



        }
    }
}
