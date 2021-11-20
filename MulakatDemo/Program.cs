using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulakatDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a function that calculates and returns the following sum:
            // (1 x 2 - 3 x 4) + (5 x 6 - 7 x 8 ) + ... + (997 x 998 - 999 x 1000)

            // 1. Çözüm:
            //int a = 1;
            //int b = 2;
            //int c = 3;
            //int d = 4;
            //int sonuc = 0;

            //while (a <= 997)
            //{
            //    sonuc += a * b - c * d;
            //    a += 4;
            //    b += 4;
            //    c += 4;
            //    d += 4;
            //}
            //Console.WriteLine(sonuc);

            int a = 1;
            int sonuc = 0;
            while (a <= 997)
            {
                sonuc += a * (a + 1) - (a + 2) * (a + 3);
                a += 4;
            }


            Console.WriteLine(sonuc);

            Console.ReadLine();
        }
    }
}
