using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals8523
{
    class Program
    {
        static void Main(string[] args)
        {
            // Logical operators: &&<-->(and), ||<-->(or), !<-->(not)
            // Relation operators: ==, !=(eşit değildir), >=(büyük veya eşit), <=(küçük veya eşit), <, >
            // Arithmetic operators: +, -, *, /, %(kalan)
            // Assignment operator: =
            Console.ForegroundColor = ConsoleColor.Red;
            var number = 10;
            if (number == 10)
            {
                Console.WriteLine("Number is 10");
            }
            else  // number != 10(Eşit değil 10), (number == 10)
            {
                Console.WriteLine("Number is not 10"); 
            }

            number = 11;
            Console.WriteLine(number == 10 ? "Number is 10" : "Number is not 10"); // ternary operator(?)

            number = 20;
            if (number == 10)
                Console.WriteLine("Ten");
            else if (number == 20)
                Console.WriteLine("Twenty");
            else
                Console.WriteLine("Not Ten or Twenty");

            switch (number)
            {
                case 10: 
                    Console.WriteLine("Ten");
                    break;
                case 20:
                    Console.WriteLine("Twenty");
                    break;               
                default:
                    Console.WriteLine("Not Ten or Twenty");
                    break;
            }
            
            
            Console.ReadLine();

        }   

    }
}
