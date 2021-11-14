using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //string student1 = "Çağıl";
            //string student2 = "Leo";
            //string student3 = "Angel";

            //string[] students = new string[3];
            //students[0] = "Çağıl";
            //students[1] = "Leo";
            //students[2] = "Angel";
            ////students[3] = "Muhittin"; // run time exception

            ////int[] numbers = new int[4] // buda olabilir.
            ////{
            ////    1, 2, 3, 4
            ////};

            //int[] numbers = new[]
            //{
            //    1, 2, 3, 4
            //};
            //decimal[] decimals = new decimal[] { 1.1m, 2.2m };
            //char[] characters = { 'A', 'b', 'i' };

            //Console.WriteLine(students[0]); //Çağıl

            ////Console.WriteLine(students);
            //foreach (var student in students)
            //{
            //    Console.WriteLine(student);
            //}
            //for (int i = 0; i < students.Length; i = i + 1)
            //{
            //    Console.WriteLine(students[i]);
            //}


            #region Multi Dimensional Arrays: Çok Boyutlu Diziler
            string[,] bolgelerVeSehirler = new string[3, 2];
            bolgelerVeSehirler[0, 0] = "Marmara";
            bolgelerVeSehirler[0, 1] = "İstanbul";
            bolgelerVeSehirler[1, 0] = "İç Anadalu";
            bolgelerVeSehirler[1, 1] = "Ankara";
            bolgelerVeSehirler[2, 0] = "Akdeniz";
            bolgelerVeSehirler[2, 1] = "Adana";
            //foreach (var bolgeveSehir in bolgelerVeSehirler)
            //{
            //    Console.WriteLine(bolgeveSehir);
            //}
            BolgeSehirYazdır(bolgelerVeSehirler);
            bolgelerVeSehirler = new string[2, 3] // 2-->0, 3-->1
            {
                { "Marmara ", "İç Anadolu ", " Akdeniz" },
                { "İstanbul ", " Ankara", " Adana" }
            };
            BolgeSehirYazdır(bolgelerVeSehirler);

            #endregion
            Console.ReadLine();


        }

        private static void BolgeSehirYazdır(string[,] bolgelerVeSehirler)
        {
            for (int satir = 0; satir <= bolgelerVeSehirler.GetUpperBound(0); satir = satir + 1)
            {
                for (int sutun = 0; sutun <= bolgelerVeSehirler.GetUpperBound(1); sutun = sutun + 1)
                {
                    Console.Write(bolgelerVeSehirler[satir, sutun] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
