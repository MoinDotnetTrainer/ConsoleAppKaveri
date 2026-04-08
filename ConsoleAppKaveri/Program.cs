namespace ConsoleAppKaveri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            /*
            ClassExample obj = new ClassExample();
            obj.Add();
            obj.Sub();
            obj.test();
            obj.Mul(43, 25);
            obj.Div(y: 12, x: 2); //Named Pm
            obj.Ops(12, 2); // default pm
            obj.Cal(12, 23, 3, 45, 45, 56, 56, 6, 76); // default pm

            int res = obj.Addition();  // print the add value
            if (res == 90)
            {
                Console.WriteLine("do this");
            }
            else
            {
                Console.WriteLine("do that");
            }

            MethodOverload obj1 = new MethodOverload();
            obj1.M1(12);

            Console.WriteLine(56.56);

            Staticmethods obj2 = new Staticmethods();
            obj2.Add();  //object

            // create an oject 
            Staticmethods.Sub(); // class


            Constr c = new Constr(45);  // static , Non 
           */


            //   ConstrChain obj = new ConstrChain(334);

            MultipleReturnType obj = new MultipleReturnType();
            (int x, string y) = obj.T3(12, "kaveri");
            Console.WriteLine(x);
            Console.WriteLine(y);

            obj.T4(12, 23, out int Add, out int Sub);
            Console.WriteLine(Add);
            Console.WriteLine(Sub);
        }
    }
}
