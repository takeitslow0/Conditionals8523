using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            //byte sayi = 100;
            //if (sayi >= 0 && sayi <= 100)
            //{
            //    Console.WriteLine("Sayı 0 ile 100 arasındadır.");
            //}
            //else if (sayi >= 100 && sayi <= 200)
            //{
            //    Console.WriteLine("Sayı 100 ile 200 arasındadır.");
            //}
            //else // sayı > 200 || sayı 0'dan küçükse
            //{
            //    Console.WriteLine("Sayı 200'den büyüktür.");
            //}

            ////if (sayi < 0 || sayi > 200)
            //if(!(sayi >= 0 && <= 200))
            //{
            //    Console.WriteLine("Sayı 200'den büyüktür veya 0'dan küçüktür");
            //}
            //else if (sayi > 100 && sayi <= 200)
            //{
            //    Console.WriteLine("sayı 100 ile 200 arasındadır.");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı 0 ile 100 arasındadır.");
            //}

            Console.Write("Sayı Gir: ");
            string giris = Console.ReadLine();
            int sayi = Convert.ToInt32(giris);
            if (sayi < 0)
            {
                Console.WriteLine("Sayı Negatifir.");
            }
            else if (sayi > 0)
            {
                Console.WriteLine("Sayı Pozitiftir.");
            }
            else
            {
                Console.WriteLine("Sayı Sıfırdır.");
            }
            Console.ReadLine();
            Console.WriteLine("LOL");
    }


    }
}
