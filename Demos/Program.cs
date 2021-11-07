using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Adınız: ");
            string ad = Console.ReadLine();
            Console.Write("Yaşınız: ");
            int yas = Convert.ToInt32
                (Console.ReadLine());
            Console.Write("Eğitim Durumu (İlkokul: i, ortaokul: o, lise: l, üniversite: ü): ");
            string egitim = Console.ReadLine();
            Console.Write("Renk körü müsün? (Evet: e, Hayır: h)");
            string renkKoruMu = Console.ReadLine();
            //if (yas >=18)
            //{
            //    if (egitim == "l" || egitim == "ü")
            //    {


            //        if (renkKoruMu == "h")
            //        {
            //            Console.WriteLine("Sayın " + ad + ", ehliyet alabilirsiniz.");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Sayın " + ad + ", ehliyet alamazsınız. Çünkü Renk körü hastalığınız vardır.");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Sayın " + ad + ", ehliyet alamazsınız. Çünkü eğitim durumunuz kriterleri karşılamıyor");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Sayın " + ad + ", ehliyet alamazsınız. Çünkü yaşınız 18den küçük." );

            //}
            if (yas >= 18 && (egitim == "l" || egitim == "ü") && renkKoruMu == "h")

            {
                Console.WriteLine("Sayın " + ad + ", ehliyet alabilirsiniz.");
            }
            else //(yas < 18 || (egitim != "l" && egitim != "ü") || renkKoruMu != "h")
            {
                Console.WriteLine("Sayın " + ad + "Ehliyet alamazsınız.");
            }

            
            
            Console.ReadLine();


        }
    }
}
