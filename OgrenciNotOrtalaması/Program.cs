using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciNotOrtalaması
{
    class Program
    {
        static void Main(string[] args)
        {
            string ad;
            string soyad;
            int vize1;
            int vize2;
            double final;
            double ortalama;
            const double vizecarpan = 0.2;
            const double finalcarpan = 0.6;

            Console.Write("Adınız: ");
            ad = Console.ReadLine();

            Console.Write("Soyadınız: ");
            soyad = Console.ReadLine();

            Console.Write("1. Vize: ");
            vize1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("2. vize: ");
            vize2 = int.Parse(Console.ReadLine());

            Console.Write("Final: ");
            final = Convert.ToInt32(Console.ReadLine());

            ortalama = (vize1 + vize2) * 0.2 + (final * 0.6);

            Console.WriteLine("Sayın " + ad + " " + soyad + ", ortalamanız: " + ortalama);
            Console.ReadLine();

            if (ortalama >=60)
                Console.WriteLine("Tebrikler, geçtiniz.");
            else
                Console.WriteLine("Tebrikler Kaldınız.");

            Console.Write("Adınız: ");
            ad = Console.ReadLine();

            Console.Write("Soyadınız: ");
            soyad = Console.ReadLine();

            Console.Write("1. Vize: ");
            vize1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("2. vize: ");
            vize2 = int.Parse(Console.ReadLine());

            Console.Write("Final: ");
            final = Convert.ToInt32(Console.ReadLine());

            ortalama = (vize1 + vize2) * 0.2 + (final * 0.6);

            Console.WriteLine("Sayın " + ad + " " + soyad + ", ortalamanız: " + ortalama);
            Console.ReadLine();

            if (ortalama >= 60)
                Console.WriteLine("Tebrikler, geçtiniz.");
            else
                Console.WriteLine("Tebrikler Kaldınız.");

            Console.ReadLine();
            
        }
    }
}
