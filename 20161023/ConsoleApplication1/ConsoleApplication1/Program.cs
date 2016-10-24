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
            int[] a = { 1, 5, 15, 25, 35, 45 };
            int[] b = { 1, 10, 20, 30, 40 ,1};
            int c;
            c = Naji(a, b);

            Console.WriteLine(c);
            Console.ReadKey();
        }

        static int Naji(int[] a,int[]b) {
            int sum = 0;
            for (int i = 0; i < a.Length; i++) {
                sum += a[i] * b[i];
            }
            return sum;            
        }
    }
}
