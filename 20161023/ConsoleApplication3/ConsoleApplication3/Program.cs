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
            int[] a = { 1, 5, 15, 25, 35, 45 };
            int[] b = { 1, 10, 20, 30, 40, 50 };
            Console.WriteLine(Yushain(a, b));
            Console.ReadKey();
        }

        static double Yushain(int[] a, int[] b) {
            double a_lengh = 0;
            double b_lengh = 0;
            double naiji = 0;
            double sum = 0;
            for (int i = 0; i < a.Length; i++) {
                a_lengh += a[i] * a[i];
            }
            for (int i = 0; i < b.Length; i++) {
                b_lengh += b[i] * b[i];
            }
            for (int i = 0; i < a.Length; i++) {
                naiji += a[i] * b[i];
            }
            sum = naiji/Math.Sqrt(a_lengh)* Math.Sqrt(b_lengh);
            return sum;
            
        }
    }
}
