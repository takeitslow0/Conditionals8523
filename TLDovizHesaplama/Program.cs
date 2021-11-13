using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TLDovizHesaplama
{
    class Program
    {
        static void Main(string[] args)
        {/*
            1. başla
            2. kullanıcıdan tl cinsinden para girilmesi istenir
            3. kullanıcı para girer
            4. kullanıcıdan para birimi girilmesi istenir (Dolar: d, Euro: e, Pound: p)
            5.1 eğer para birimi dolar ise
            5.2 kullanıcının girdiği parayı tanımlı olan dolar kuruna böl
            5.3 eğer para birimi euro ise
            5.4 kullanıcının girdiği parayı tanımlı olan euro kkuruna böl
            5.5 eğer para birimi pound ise
            5.6 kullanıcının girdiği parayı tanımlı olan pound kuruna böl
            5.7 eğer adamın girmiş olduğu para birimi dolar, euro, pound değil ise
            5.8 kullanıcıdan doğru tanımlı para birimi girilmesi istenir.
            6. hesaplama sonucu ekrana yazdır.
            7. bitir
          */

            Console.ForegroundColor = ConsoleColor.Blue;
            
            string tarih = "13.11.2021";
            double tl;
            string paraBirimi;
            double dolar = 10, euro = 11.4, pound = 13;
            
            

            Console.Write("TL cinsinden para giriniz: ");
            tl = Convert.ToDouble(Console.ReadLine());

            Console.Write("Para birimi giriniz: (Dolar: d, Euro: e, pound: p)");
             paraBirimi = Console.ReadLine();


            //if (paraBirimi != "d" && paraBirimi != "e" && paraBirimi != "p")
            if (!(paraBirimi == "d" || paraBirimi == "e" || paraBirimi == "p"))
            {
                Console.WriteLine("404 ERROR NOT FOUND");
            }
            else  // paraBirimi == "d" || paraBirimi == "e" || paraBirimi == "p"
            {
                double sonuc;
                if (paraBirimi == "d")

                    sonuc = tl / dolar;
                else if (paraBirimi == "e")
                sonuc = tl / euro;
                else
                    sonuc = tl / pound;
                Console.WriteLine("Tarih: " + tarih + "\nDöviz Sonucu: " + sonuc);
            }
            Console.ReadLine();
        }


        
    }
}
