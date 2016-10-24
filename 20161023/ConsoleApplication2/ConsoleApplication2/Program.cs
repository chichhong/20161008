using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 5, 15, 25, 35, 45 };
            double sum = ArrayLengh(a);
            Console.WriteLine(sum);
            Console.ReadKey();
        }
        static double ArrayLengh(int[] a)
        {
            double sum = 0;
            for (int i = 0; i < a.Length; i++) {
                sum += a[i] * a[i];
            }
            sum = Math.Sqrt(sum);
            return sum;
        }
    }
}
