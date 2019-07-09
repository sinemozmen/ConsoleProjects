using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject23
{
    class Program
    {
        static void Main(string[] args)
        {
            // BINARY SEARCH
            int altSinir = 0;
            int ustSinir = 100;
            int ortalama;

            int sayac = 1;

            int tuttuguSayi = (new Random()).Next(1,100);

            Console.WriteLine("BINARY SEARCH Başlıyor...");
            Console.ReadLine();

            while (true)
            {
                ortalama = (altSinir + ustSinir) / 2;
                Console.WriteLine(sayac + ". tahmin = " + ortalama);
                Console.ReadLine();
                if (ortalama > tuttuguSayi)
                {
                    ustSinir = ortalama;
                    Console.WriteLine("Tahmin sayısı, bilgisayarın tuttuğu sayıdan BÜYÜKTÜR");
                    Console.ReadLine();
                    sayac++;
                    continue;
                }
                else if (ortalama < tuttuguSayi)
                {
                    altSinir = ortalama;
                    Console.WriteLine("Tahmin sayısı, bilgisayarın tuttuğu sayıdan KÜÇÜKTÜR");
                    Console.ReadLine();
                    sayac++;
                    continue;
                }
                else
                {
                    Console.WriteLine(sayac + ". denemede " + tuttuguSayi +" sayısını BULDUNUZ");
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
