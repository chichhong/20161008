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
            int[,] a = { { 20,24,28}, { 30,34,38}, { 40,44,48}, { 50,54,58} };
            int[,] b = new int[4,3];
            Add_1(a, b);
            foreach (int i in b)
                Console.WriteLine(i);


            b = Add_2(a);
            foreach (int i in b)
                Console.WriteLine(i);


            Console.ReadKey();

        }

        static void Add_1(int[,] a, int[,] b) {
            for (int i = 0; i < a.GetLength(0); i++) {
                for (int j = 0; j < a.GetLength(1); j++)
                    b[i, j] = a[i, j] + 1;
            }
        }

        static int[,] Add_2(int[,] a) {
            int[,] b = new int[a.GetLength(0),a.GetLength(1)];
            for (int i = 0; i < a.GetLength(0); i++) {
                for (int j = 0; j < a.GetLength(1); j++)
                    b[i, j] = a[i, j]+1;
            }

            return b;
        }
    }
}
