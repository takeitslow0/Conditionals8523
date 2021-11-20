using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops8523
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;

            //for (int i = 1; i <= 10; i += 1)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine();
            //for (int t = 1; t < 20; t = t + 2)
            //{
            //    Console.WriteLine(t);
            //}
            //Console.WriteLine();
            //for (int i = 2; i <= 50; i += 2)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 30; i > 1; i -= 2)
            //{
            //    Console.WriteLine(i);
            //}

            //int j;
            //for (j = 1; j <= 5; j += 1)
            //{

            //}
            //Console.WriteLine(j); // 6 dahil yazdırır.
            //Console.WriteLine();
            for (int i = 1; i <= 5; i++) // i++ ile i += 1 ile i = i +1 aynı şeylerdir.
            {
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = 4; i >= 1; i--)
            {
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            int sayi = 1;
            while (sayi <= 10)
            {
                Console.WriteLine(sayi);
                sayi++;
            }
            Console.WriteLine();

            int number = 10; // initial value
            do
            {
                Console.WriteLine(number);
                number--;  //i increment
            } while (number >= 1); // condition

            string[] students = new string[3]
            {
                "Çağıl", "Leo", "Angel"
            };
            foreach (string student in students)
            {
                //students = "Yağız";
                Console.WriteLine(student);
            }

            for (int i = 0; i < students.Length; i++)
            {
                //students[i] = "Yağız";
                Console.WriteLine(students[i]);
            }


            int s = 0;
            while (s >= students.Length)
            {
                Console.WriteLine(students[s]);
                s++;
            }
            int x = 0;
            do
            {
                Console.WriteLine(students[x]);
                x++;

            } while (x < students.Length);

            int no = 1;
            Console.WriteLine(no++); // 1
            Console.WriteLine(no); // 2

            int n1 = 10, n2 = 5;
            n1 += n2; // n1 = 15

            string ad = "Çağıl";
            string bosluk = " ";
            string soyad = "Alsaç";
            ad = ad + bosluk + soyad;
            ad += bosluk + soyad;
            Console.WriteLine(ad);


            Console.ReadLine();

        }

    }
}
