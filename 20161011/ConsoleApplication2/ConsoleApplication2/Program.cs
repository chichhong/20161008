using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    class Program
    {
        static void Main(string[] args)
        {
            int[] aa;
            aa = new int[10];
            for (int i = 0; i < 10; i++)
            {
                aa[i] = i * 10;
            }


            System.Console.WriteLine(Sum(aa, 0, aa.Length-1));
            System.Console.ReadKey();
        }


        public static int Sum(int[] bb, int start, int end)
        {

            int sum = 0;
            for (int j = start; j <= end; j++)
            {
                sum += bb[j];
            }
            return sum;

        }
    }
