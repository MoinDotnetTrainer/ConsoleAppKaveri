using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppKaveri
{
    internal class Async
    {
        public int getWordCount(string filename)
        {
            int len = 0;
            using (StreamReader reader = new StreamReader(filename))
            {
                string words = reader.ReadToEnd();
                len = words.Length;
                Task.Delay(10000).Wait();       // make into sleep 10 sec
            }
            return len;
        }

        public void Exe()
        {
            string file = "C:\\Users\\ADMIN\\OneDrive\\Desktop\\IRFAN.txt";
            int result = getWordCount(file);

            Console.WriteLine("task 1");
            Console.WriteLine("task 2");
            Console.WriteLine("task 3");
            Console.WriteLine("Finals words count :" + result);  // synch
            Console.WriteLine("task 4");
            Console.WriteLine("task 5");
            Console.WriteLine("task 6");
        }

        public async Task<int> getWordCount1(string filename)
        {
            int len = 0;
            using (StreamReader reader = new StreamReader(filename))
            {
                string words = await reader.ReadToEndAsync();  // Thread
                len = words.Length;
                Task.Delay(10000).Wait();       // make into sleep 10 sec
            }
            return len;
        }

        public async void Exe1()
        {
            string file = "C:\\Users\\ADMIN\\OneDrive\\Desktop\\IRFAN.txt";
            Task<int> result = getWordCount1(file);

            Console.WriteLine("task 1");
            Console.WriteLine("task 2");
            Console.WriteLine("task 3");
            int finalwords = await result;
            Console.WriteLine("Finals words count :" + finalwords);  // synch
            Console.WriteLine("task 4");
            Console.WriteLine("task 5");
            Console.WriteLine("task 6");
        }

    }
}
