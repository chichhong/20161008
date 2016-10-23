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
            int x = 3, y = 5;
            x = y;
            x = x << 2;

            Console.WriteLine("x = "+x +",y ="+ y);

            bool t = true, u = false;
            bool a = t && u;
            bool b = t || u;
            bool c =! u;

            Console.WriteLine("a = " + a + ",b =" + b + ",c =" + c );

            int d = x & y;
            int e = x | y;

            Console.Write("d = " + d + ",e =" + e);

            System.Console.ReadKey();
        }
    }
}
