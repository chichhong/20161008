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
            
            int b;
            int sum = 0, c = 0;
            //for (bool a = true; a == true; )
            //{

            //    Console.WriteLine("輸入數字");
            //    b = Int32.Parse(Console.ReadLine());

            //    if (b == 0)
            //    {
            //        a = false;
            //    }
            //    else
            //    {
            //        sum += b;
            //        c++;
            //    }
            //}


            while(true)
            //for (;;)
            {

                Console.WriteLine("輸入數字");
            b = Int32.Parse(Console.ReadLine());

            if (b == 0)
            {
               break;
            }
            else
            {
                sum += b;
                c++;
            }
        }
        Console.WriteLine(sum);
            Console.WriteLine(c);
            Console.WriteLine((float)sum / c);
            Console.ReadKey();

        }
    }
}
