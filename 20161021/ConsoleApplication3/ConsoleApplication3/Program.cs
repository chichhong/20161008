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
            int[][] b = new int[][] { new int[] { 20,24,28},new int[] { 30,34,38},new int[] { 40,44,48},new int[] { 50,54,58} };
            int[][] c = new int[][] { new int[b.GetLength(0)], new int[b.GetLength(1)] };
            

           Add_1(b, c);
            foreach (int i in c) {
                
            }


            c = Add_2(b);
            foreach (int i in c) {

            }
        }


        static void Add_1(int[][] b,int[][] c) {
            for (int i = 0; i < b.GetLength(0); i++) {
                for (int j = 0; j < b.GetLength(1); j++) {
                    c[i][j] = b[i][j] + 1; 
                }

            }
        }


        static int[][] Add_2(int[][] b) {
            int[][] c = new int[][] { new int[b.GetLength(0)], new int[b.GetLength(1)] }; ;
            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    c[i][j] = b[i][j] + 1;
                }

            }
            return c;
        }
    }
}
