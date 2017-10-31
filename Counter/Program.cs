using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            Console.WriteLine("Hello World in 10");
            while (i > 0)
            {
                Console.WriteLine(i);
                i = (i - 1);
                Thread.Sleep(1000);
            }
            Console.Write("Hello World");
            Console.ReadKey(true);          
        }
    }
}
