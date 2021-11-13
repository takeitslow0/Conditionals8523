using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Red;
            DisplayAdd();
            int number1 = 1;
            int number2 = 2;
            AddWithoutResult(number1, number2);
            AddWithoutResult(5, 7);

            int result = AddWithResult(number1, number2);
            Console.WriteLine("Result: " + result);

            double pi = GetPI();
            double radius = 5;
            double area = pi * radius * radius;
            Console.WriteLine("Daire alanı: " + area);

            string res = Subtract(9, 8, 7);
            Console.WriteLine(res);
            Console.WriteLine("Fark: " + Subtract(10, 9, 8, 7));

            var sonuc = Add(1, 2); // 503
            sonuc = Add(1, 2, 3); // 6
            Console.WriteLine(sonuc);

            int c1 = 5, c2 = 10, c3 = 15, c4 = 20;
            int t = Addition(c1, c2, c3, c4);
            Console.WriteLine(t);

            t = Addition(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
            Console.WriteLine(t);
            Console.ReadLine();
        }

        static int Addition(params int[] numbers)
        {
            return numbers.Sum();
        }

        static string Subtract(int v1, int v2, int v3)
        {
            int result = v1 - v2 - v3;
            //string resultString = "" + result;
            //resultString = Convert.ToString(result);
            string resultString = result.ToString();
            return "" + (v1 - v2 - v3);
        }
        static double Subtract(double s1, double s2, double s3, double s4)
        {
            return s1 - s2 - s3 - s4;
        }
        static void DisplayAdd()
        {
            Console.WriteLine("Added!");
        }

        static void AddWithoutResult(int number1, int number2)
        {
            int result = number1 + number2;
            Console.WriteLine(number1 + "+" + number2 + "=" + result);
        }
        static int AddWithResult(int n1, int n2)
        {
            //int result = n1 + n2;
            //return result;
            return n1 + n2;
        }

        static double GetPI()
        {
            return 3.14;
        }

        static long Add(int s1, int s2, int s3 = 500) // Add(10, 20, 30) - Add(50, 60)
        {
            return s1 + s2 + s3;
        }

    }


}




