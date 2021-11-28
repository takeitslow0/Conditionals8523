using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;


            string ornek = "as good as it gets.";
            string deger = "as";
            int index = ornek.IndexOf(deger); // 0
            Console.WriteLine(index);
            int lastIndex = ornek.LastIndexOf(deger); // 8
            string tersineOrnek = TersineCevir(ornek);
            string tersineDeger = TersineCevir(deger);
            int tersineLastIndex = tersineOrnek.IndexOf(tersineDeger); // 9 
            Console.WriteLine(tersineLastIndex);

            Console.ReadLine();
        }


        static string TersineCevir(string deger)
        {
            string sonuc = "";
            for (int i = deger.Length - 1; i >= 0; i--)
            {
                sonuc += deger[i];
            }
            return sonuc;
        }
    }
}
