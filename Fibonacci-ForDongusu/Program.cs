using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_ForDongusu
{
    class Program
    {
        static void Main(string[] args)
        {
            using System;

namespace ConsoleProject_026
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Kaç tane fibonacci sayısı atmak ister siniz?");
                int sayi = Convert.ToInt32(Console.ReadLine());

                int birinciSayi = 0;
                int ikinciSayi = 1;

                string fibonacciSerisi = "";

                int[] fibonacciNumbersAray = new int[sayi];
                fibonacciNumbersAray[0] = 0;
                fibonacciNumbersAray[1] = 1;

                //Console.Write(birinciSayi + " " + ikinciSayi + " ");

                for (int i = 0; i < sayi - 2; i++)
                {
                    int Temp = birinciSayi + ikinciSayi;
                    fibonacciNumbersAray[i + 2] = Temp;

                    if (i == sayi - 3)
                        fibonacciSerisi = fibonacciSerisi + Temp;
                    else
                        fibonacciSerisi = fibonacciSerisi + Temp + " , ";

                    birinciSayi = ikinciSayi;
                    ikinciSayi = Temp;
                }
                if (fibonacciSerisi == "")
                {
                    fibonacciSerisi = "0, 1,";
                }
                else
                {
                    fibonacciSerisi = "0 , 1 , " + fibonacciSerisi;
                }
                Console.WriteLine(fibonacciSerisi);

                int sayac = 0;
                foreach (int fn in fibonacciNumbersAray)
                {
                    sayac++;
                    if (fibonacciNumbersAray.Length == sayac)
                        Console.Write(fn);
                    else
                        Console.Write(fn + " , ");
                }
                Console.ReadLine();
            }
        }
    }

}
    }
}
