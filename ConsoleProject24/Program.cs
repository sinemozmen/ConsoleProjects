using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject24
{
    class Program
    {
        static void Main(string[] args)
        {
            // BINARY SEARCH
            int altSinir=0;
            int ustSinir=100;
            int ortalama;
            int sayac=1;

            Console.WriteLine("BINARY SEARCH Oyunu Başlıyor....");
            Console.ReadLine();
            Random rnd = new Random();// rnd isimli bir Random Class instance oluşturduk.
            int tutulanSayi = rnd.Next(1, 100);
            while(true)
            {
                ortalama = (altSinir + ustSinir) / 2;
                Console.WriteLine(sayac + ".Tahmin = " + ortalama);
                Console.ReadLine();

                if(ortalama>tutulanSayi)// ort 50 tutulan 30 100-1
                {
                    Console.WriteLine("Tahmin , tutulan sayıdan BÜYÜKTÜR");
                    Console.ReadLine();
                    ustSinir = ortalama;
                    sayac++;
                    continue;
                }
                else if(ortalama > tutulanSayi)
                
                {
                    Console.WriteLine("Tahmin , tutulan sayıdan KÜÇÜKTÜR");
                    Console.ReadLine();
                    altSinir = ortalama;
                    sayac++;
                    continue;

                }
                else
                {
                    Console.WriteLine(sayac + ". denemede " + tutulanSayi + " sayısını buldunuz");
                    Console.ReadLine();
                    break;
                }

            }
        }
    }
}
