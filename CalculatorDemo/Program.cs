using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1. sayı: ");
            double sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("2.Sayı: ");
            double sayi2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("(+, -, *, /): ");
            string islem = Console.ReadLine();
            double islemsonucu = IslemYap(sayi1, sayi2, islem);
            Console.WriteLine("Sonuç: " + islemsonucu);
            Console.ReadLine();
        }

        static double IslemYap(double sayi1, double sayi2, string islem)
        {
            double sonuc;
            if (islem == "+")
                sonuc = sayi1 + sayi2;
            else if (islem == "-")
                sonuc = sayi1 - sayi2;
            else if (islem == "*")
                sonuc = sayi1 * sayi2;
            else // islem == "/"
                sonuc = sayi1 / sayi2;
            return sonuc;


        }

    }
}
