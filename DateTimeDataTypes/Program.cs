using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime simdi = DateTime.Now;
            Console.WriteLine(simdi);
            Console.WriteLine(simdi.ToShortDateString());
            Console.WriteLine(simdi.ToLongDateString());
            Console.WriteLine(simdi.ToShortTimeString());
            Console.WriteLine(simdi.ToLongTimeString());
            Console.WriteLine(simdi.ToShortDateString() + " " + simdi.ToLongTimeString());
            Console.WriteLine(simdi.Month + "/" + simdi.Day + "/" + simdi.Year + " " + simdi.Hour + ":" + simdi.Minute + ":" + simdi.Second + "." + simdi.Millisecond);

            DateTime tarih = new DateTime(2021, 11, 28, 19, 17, 0);
            Console.WriteLine(tarih);
            Console.ReadLine();

        }
    }
}
