using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        public static void Main()
        {
            //ConsoleKeyInfo a =Console.ReadKey();
            //int sum = 0;

            //while (a.Key != ConsoleKey.Escape)
            //{
            //   int b  = Console.Read();

            //    Console.WriteLine("you're typeing" + b);
            //    sum += b;
            //    Console.WriteLine("the total is sum");

            //}


            bool a = true;
            int b;
            int sum = 0,c=0;


            while (a)
            {
                Console.WriteLine("輸入數字");
                b = Int32.Parse(Console.ReadLine());
               
                if (b == 0)
                {
                    a = false;
                }
                else
                {
                    sum += b;
                    c++;
                }
            }

            //Console.WriteLine("輸入數字");
            //b = Int32.Parse(Console.ReadLine());
            //Console.WriteLine(b);

            //Console.ReadKey();


            Console.WriteLine(sum);
            Console.WriteLine(c);
            Console.WriteLine((float)sum/c);
            Console.ReadKey();


        }
    }
}  
