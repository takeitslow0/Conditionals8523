using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KelimeAramaDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Cümle: ");
            string cumle = Console.ReadLine();
            Console.Write("Kelime: ");
            string kelime = Console.ReadLine();
            string sonuc;
            // "1. YÖNTEM": 
            //if (cumle.IndexOf(kelime) == -1)
            //     sonuc = "\"" + cumle + "\" içerisinde\" " +  kelime + "\" bulunamadı.";
            //else
            //    sonuc = "\"" + cumle + "\" içerisinde\" " +  kelime + "\" bulundu.";
            // 2. YÖNTEM

            //if (cumle.Contains(kelime))
            //    sonuc = "\"" + cumle + "\" içerisinde\"" + kelime + "\" bulundu.";
            //else
            //    sonuc = "\"" + cumle + "\" içerisinde\"" +  kelime + "\" bulunamadı.";

            string[] cumleKelimeleri = cumle.Split(' ');
            bool bulundu = false; // flag
            foreach (string cumleKelime in cumleKelimeleri)
            {
                if (cumleKelime == kelime)
                {
                    bulundu = true;
                }
            }
            if (bulundu == true)
                sonuc = "Aradığınız kelime cümle içerisinde bulundu.";
            else
                sonuc = "Aradığınız kelime cümle içerisinde bulunamadı.";
            Console.WriteLine(sonuc);
            Console.ReadLine();

        }
    }
}
