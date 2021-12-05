using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamAsmacaLite
{
    class Program
    {
        /*
        ***** çağıl
        ç --> ç****
        z--> ç****
        ğ--> ç*ğ**
        */
        static void Main(string[] args)
        {
            string[] kelimeler = new string[5]
            {
                "çağıl","leo","boğaç","yağız","simge"
            };
            Random rastgele = new Random();
            rastgele.Next(0, kelimeler.Length);
            int rastgeleIndex = rastgele.Next(0, kelimeler.Length);
            Console.ForegroundColor = ConsoleColor.Red;
            string kelime = kelimeler[rastgeleIndex];
            bool bildimMi = false;
            string sonuc = "";
            for (int i = 0; i < kelime.Length; i++)
            {
                sonuc += "*";
            }

            Console.WriteLine(sonuc);
            char[] sonucharfler = new char[sonuc.Length];
            for (int i = 0; i < sonucharfler.Length; i++)
            {
                sonucharfler[i] = sonuc[i];
            }
            int hak = kelime.Length;
            do
            {
                Console.Write("Harf gir!: ");
                string harf = Console.ReadLine();
                if (harf == kelime)
                {
                    bildimMi = true;
                    break;
                }
                int index = kelime.IndexOf(harf);
                if (index >= 0)
                {
                    sonucharfler[index] = kelime[index];
                }
                else
                {
                    hak--;
                }
                sonuc = "";
                foreach (char sonucHarf in sonucharfler)
                {
                    sonuc += sonucHarf;
                }
                if (!sonuc.Contains("*"))
                {
                    bildimMi = true;
                }

                Console.WriteLine(sonucharfler);

            }
            while (hak > 0 && !bildimMi);
            if (!bildimMi)
                Console.WriteLine("Başaramadık Abi En baştan yallah!");
            else
                Console.WriteLine("Bravo. Oyun Bitti.(Çıkmak için herhangi bir tuşa BAS !)");

            Console.ReadLine();
        }
    }
}
