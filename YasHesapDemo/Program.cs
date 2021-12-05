using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YasHesapDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //int yil;
            //int yas;
            //Console.WriteLine("Doğum Yılınızı Giriniz: ");
            //yil = Convert.ToInt32(Console.ReadLine());

            //yas = DateTime.Now.Year - yil;
            //Console.Write(yas + "yaşındasınız.");

            Console.Write("Doğum Tarihi (gg.aa.yyyy): ");
            DateTime dogumTarihi = DateTime.Parse(Console.ReadLine(), new CultureInfo("tr"));
            DateTime simdikiTarih = DateTime.Now;
            //int yas = simdikiTarih.Year - dogumTarihi.Year;
            TimeSpan fark = simdikiTarih.Subtract(dogumTarihi);
            int yas = (int)(fark.TotalHours / (365 * 24 + 6));

            Console.WriteLine($"{yas} yaşındasınız.");
            Console.ReadLine();
        }
    }
}
