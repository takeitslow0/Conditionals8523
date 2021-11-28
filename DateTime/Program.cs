using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //escape sequences
            string name = "Çağıl";
            string escapedName = "\"Çağıl\""; // Çağıl
            Console.WriteLine(escapedName);
            String surname = "Alsaç";
            escapedName = name + "\n" + surname;
            Console.WriteLine(escapedName);
            escapedName = name + "\t" + surname;
            Console.WriteLine(escapedName);
            string path1 = "C:\\BA\\Console"; // C:\BA\Console
            path1 = @"C:\BA\Console"; // c:\BA\Console



            Console.ReadLine();
        }
    }
}
