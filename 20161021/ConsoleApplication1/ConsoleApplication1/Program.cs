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
            int[] a = new int[]{ 5, 15, 25, 35, 45, 55, 65, 75 };
            int[] b = new int[] { 10, 20, 30, 40, 50, 60, 70, 80 };
            int[] c = new int[8];
            //int[] c;
            add_1(a, b, c);
            foreach (int i in c)
            {
                Console.WriteLine(i);
            }


            c = add_2(a, b);
            foreach(int i in c)
            Console.WriteLine(i);

            Console.ReadKey();
        }

        static void add_1(int[] a, int[] b, int[] c) {
            for (int i = 0; i < a.Length; i++) {
                c[i] = a[i] + b[i];
            }
        }

        static int[] add_2(int[] a, int[] b) {
            int[] c = new int[8];
            for(int i=0;i<a.Length;i++)
                c[i] = a[i] + b[i];
            
            return c;
        }
    }
}
