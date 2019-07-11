using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject30
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] sayilar = new int[10]{ 11, 2, 5, 30, 0, 0, 0, 0, 0, 0 };
            Console.WriteLine("sayilar Array Büyüklüğü : "+ sayilar.Length);
            Console.ReadLine();

            string[]mevsimler = {"ilkbahar","yaz","sonbahar","kış"} ;
            Console.WriteLine("mevsimler Array Büyüklüğü : " + mevsimler.Length);
            Console.ReadLine();

            sayilar[4] = 4;
            sayilar[5] = 5;
            sayilar[6] = 6;
            sayilar[7] = 7;
            sayilar[8] = 8;
            sayilar[9] = 9;

            for (int i = 0; i <= 9; i++)
            {
                Console.WriteLine(i + ". eleman ------ " + sayilar[i]);
                Console.ReadLine();
            }
        }
    }
}
