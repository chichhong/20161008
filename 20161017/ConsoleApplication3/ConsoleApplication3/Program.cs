using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numbers = new int[3, 2] { { 9, 99 }, { 3, 33 }, { 5, 55 } };
            foreach (int i in numbers)
            {
                Console.Write("{0} ", i);
            }

            Console.ReadKey();
        }
    }
}
