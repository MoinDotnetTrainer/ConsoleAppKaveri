using System;
using System.Collections.Generic;
using System.IO.Pipelines;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleAppKaveri
{

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class Login
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }

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
            //Console.WriteLine(Minex);

            var Min1 = (from s in students select s).MinBy(x => x.Age); //obj

            // Console.WriteLine(Min1.Name + "-" + Min1.Age);


            //merging data

            object[] obj = { 435, 45.65, 45, 456.56, "HI", "hello", true, false };

            //int , float , string

            var typeofex = obj.OfType<bool>().ToList();
            foreach (var item in typeofex)
            {
                //
                //  Console.WriteLine(  item);
            }
            int[] arr1 = { 45, 5, 6, 76, 7, 8, 788, 9, 89, 34, 45, 5, 6, 576, 67, 67, 68, 78 };
            List<int> list1 = new List<int> { 45, 5, 6, 76, 46, 65, 76, 78, 89, 89, 9, 90, 09, 909, 090, 78978 };
            //merge
            //
            //union ,concat,intersect ,except
            var unionex = arr1.Union(list1);  // only unique
            var concat = arr1.Concat(list1); //all data
            var except = arr1.Except(list1);   // data from left
            var intersect = arr1.Intersect(list1);  // common data
            foreach (var item in intersect)
            {
                // Console.WriteLine(item);
            }

            var list11 = new List<Employee>
{
    new Employee { Id = 1, Name = "A" },
    new Employee { Id = 2, Name = "B" }
};

            var list21 = new List<Employee>
{
    new Employee { Id = 2, Name = "B2" },
    new Employee { Id = 3, Name = "C" }
};

            var result1 = list11.UnionBy(list21, e => e.Name);

            foreach (var e in result1)
            {
                //Console.WriteLine($"{e.Id} - {e.Name}");
            }

            int[] arr12 = { 45, 5, 6, 76, 7, 8, 788, 9, 89, 34, 45, 5, 6, 576, 67, 67, 68, 78 };

            var allex = (from s in arr12 select s).All(x => x > 1); //false
            var anyex = (from s in arr12 select s).Any(x => x > 5000); //false
            var containex = (from s in arr12 select s).Contains(45); //false
                                                                     // Console.WriteLine(containex);

            List<Login> login = new List<Login>()
            {
                new Login {  Name = "Preety", Email = "Female@yahoo.com", Password = "CSE" },
                new Login { Name = "Snurag", Email = "Male2@yahoo.com", Password = "ETC"  },
                new Login {  Name = "Pranaya", Email = "Male3@yahoo.com", Password = "CSE" },
                new Login {  Name = "Anurag", Email = "Male6@yahoo.com", Password = "CSE" },
                new Login { Name = "Hina", Email = "Female3@yahoo.com", Password = "ETC"},
                new Login { Name = "Priyanka", Email = "Female67@yahoo.com", Password = "CSE"},
                new Login {  Name = "santosh", Email = "Malee6@yahoo.com", Password = "CSE" },
                new Login {  Name = "Tina", Email = "Female67@yahoo.com", Password = "CSE" },
                new Login {  Name = "Celina", Email = "Female6@yahoo.com", Password = "ETC"},
                new Login {  Name = "Sambit", Email = "Male45@yahoo.com",Password = "ETC"}
            };

            var login_ = (from s in login select s).Any(x => x.Email == "Female@yahoo.com" && x.Password == "CSE");
            //Console.WriteLine(login_);

            int[] arr123 = { 23452, 435456, 45, 5, 6, 76, 7, 8, 788, 9, 89, 34, 45, 5, 6, 576, 67, 67, 68, 78 };
            //var ele = (from s in arr123 select s).ElementAt(3);
            //var ele1 = (from s in arr123 select s).ElementAtOrDefault(300);
            //var ele2 = (from s in arr123 select s).First();
            //var ele3 = (from s in arr123 select s).First(x => x > 50);
            //var ele4 = (from s in arr123 select s).Last();
            //var ele5 = (from s in arr123 select s).Last(x => x > 40);
            //var ele6 = (from s in arr123 select s).Single(x => x > 700);
            //  Console.WriteLine(ele6);

            var take = (from s in arr123 select s).Take(5);
            var takewhile = (from s in arr123 select s).TakeWhile(x => x > 2);
            var skip = (from s in arr123 select s).Skip(5);
            var skipwhile = (from s in arr123 select s).SkipWhile(x => x > 50);
            foreach (var item in skipwhile)
            {
             //   Console.WriteLine(item);
            }

            var orderby  = from s in arr123 orderby s descending select s; // asc  


            List<Student> students1 = new List<Student>()
            {
                new Student { ID = 1001, Name = "Preety", Gender = "Female", Branch = "CSE", Age = 2 },
                new Student { ID = 1002, Name = "Snurag", Gender = "Male", Branch = "ETC", Age = 45  },
                new Student { ID = 1003, Name = "Pranaya", Gender = "Male", Branch = "CSE", Age = 34  },
                new Student { ID = 1004, Name = "Anurag", Gender = "Male", Branch = "CSE", Age = 20  },
                new Student { ID = 1005, Name = "Hina", Gender = "Female", Branch = "ETC", Age = 20 },
                new Student { ID = 1006, Name = "Priyanka", Gender = "Female", Branch = "CSE", Age = 21 },
                new Student { ID = 1007, Name = "santosh", Gender = "Male", Branch = "CSE", Age = 22  },
                new Student { ID = 1008, Name = "Tina", Gender = "Female", Branch = "CSE", Age = 20  },
                new Student { ID = 1009, Name = "Celina", Gender = "Female", Branch = "ETC", Age = 22 },
                new Student { ID = 1010, Name = "Sambit", Gender = "Male",Branch = "ETC", Age = 211 }
            };

            var lazyex = from s in students1 where s.Age>25 select s; // 4 emp  // exe starts wen we call it
            var imme = (from s in students1 where s.Age > 25 select s).Count(); // 4


            students1.Add(new Student { ID = 1010, Name = "xyz", Gender = "Male", Branch = "ETC", Age = 50 });

            foreach (var item in lazyex)  // exe
            {
                //Console.WriteLine(item.Name);  // 
            }


           // Console.WriteLine(imme);  //printing

        }
    }
}
