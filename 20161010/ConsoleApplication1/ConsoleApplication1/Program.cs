﻿using System;
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
            //30加到50 
            //int sum = 0;
            //for (int a = 30; a <= 50; a++)
            //{
            //    sum += a;
            //}

            //Console.WriteLine((30 + 50) * 21 / 2);

            //System.Console.WriteLine(sum);
            System.Console.WriteLine(Add(30,50));
            System.Console.WriteLine(Avg(30, 50));


            // 100加到200
            //sum = 0;
            //for (int a = 100; a <= 200; a++)
            //{
            //    sum += a;
            //}
            //System.Console.WriteLine(sum);
            System.Console.WriteLine(Add(100, 200));
            System.Console.WriteLine(Avg(100, 200));
            //300加到500
            //sum = 0;
            //for (int a = 300; a <= 500; a++)
            //{
            //    sum += a;
            //}
            //System.Console.WriteLine(sum);
            System.Console.WriteLine(Add(300, 500));
            System.Console.WriteLine(Avg(300, 500));
            System.Console.ReadKey();
        }

        public static int Add(int a, int b)
        {
            int sum = 0;
            for (int i = a; i <= b; i++)
            {
                sum += i;
            }
            return sum;
        }

        public static float Avg(int a, int b) {
            return (Add(a, b) / (float)(b - a + 1));

        }
    }
}
