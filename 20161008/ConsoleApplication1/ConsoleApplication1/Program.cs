using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, avg;
            for (int a = 1; a <= 20 ; a++)
            {
                sum += a;
            }
            avg = sum / 20;
            System.Console.Write(avg);
            System.Console.Read();
            
        }
    }
}
