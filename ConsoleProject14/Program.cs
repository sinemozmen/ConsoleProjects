using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject14
{
    class Program
    {
        static void Main(string[] args)
        {// 1'den 100'e kadar olan sayıların toplamını yazdıma.
         //int i;
         //int toplam = 0; 

            //for (i = 1; i <= 100; i++) 
            //{

            //    toplam = toplam + i;

            //}
            //Console.WriteLine($"Toplam = {toplam} ");
            //Console.ReadLine();

            int i = 1;
            int toplam = 0;
            int adet = 0; 

            for (i = 1; i <= 1000; i++)

                if (i % 5 == 0 & i % 7 != 0)
                {
                    toplam = toplam + i;
                    adet++;
                    Console.WriteLine($"Toplam= {toplam} ve i = {i}, adet = {adet}");
                }
            Console.ReadLine();
        }
    }
}
