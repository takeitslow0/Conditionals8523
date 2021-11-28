using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İsimBulma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            string[] isimler = new string[5]
            {
                "Robert DeNiro",
                "Jennifer Lopez",
                "Robert Downey Jr.",
                "Al Pacino",
                "Kate Beckinsale"
            };
            
            Console.Write("İsim: ");
            string giris = Console.ReadLine();
            bool bulundu = false;
            foreach (string isim in isimler)
            {
                if (isim.ToUpper().Contains(giris.ToUpper()))
                {
                    bulundu = true;
                    break;
                }
            }
            if (bulundu)
            {
                Console.WriteLine(giris + " bulundu.");
            }
            else
            {
                Console.WriteLine(giris + " bulunamadı." );
            }

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
