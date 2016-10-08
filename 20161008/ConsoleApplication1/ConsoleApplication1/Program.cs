using System;

 class Program
    {
        static void Main()
        {
        int a = 0, sum = 0, avg;
        //for (int a = 1; a <= 20; a++)
        //{
        //    sum += a;
        //}


        //sum += 1;
        //sum += 2;
        //sum += 3;
        //sum += 4;
        //sum += 5;
        //sum += 6;
        //sum += 7;
        //sum += 8;
        //sum += 9;
        //sum += 10;
        //sum += 11;
        //sum += 12;
        //sum += 13;
        //sum += 14;
        //sum += 15;
        //sum += 16;
        //sum += 17;
        //sum += 18;
        //sum += 19;
        //sum += 20;


        while (a <= 20)
        {   sum += a;
            a++;  
        }

        avg = sum / 20;
            //Console.Write();
            Console.WriteLine(avg);
     
            Console.Write(sum);
            Console.Read();
            
        }
    }

