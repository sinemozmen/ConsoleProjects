using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject20
{
    class Program
    {
        static void Main(string[] args)
        {
            //pc 1-10 arasında rastgele bir sayı tutsun.

            // Tahmin sayısı > 10 değilse uyarı versin.
            // tekrar "1. tahmininiz" diye sorsun
            // kullanıcının girdiği tahmin sayısı eğer bilgisayarın tuttuğundan farklı ise
            // "2. Tahmininiz:" yazısı çıksın. Bu işlemler kullanıcının tahmin ettiği sayı, bilgisayarın tuttuğu sayıya eşit
            // olana kadar devam etsin.
            // Doğru tahmini yapınca: "Sayıyı 5.tahmininizde buldunuz" gibi bir yazı yazılsın 

            Random rnd = new Random(); // random class'i cinsinde bir instance oluşturduk, adı rnd
            int tuttuguSayi = rnd.Next(1, 10);
            // int tuttuguSayi = (new Random()).Next(1,10);

            int sayac = 1;
            int sayiTahmin;
            string tahmin;

            while (true)
            {
                Console.Write(sayac + ".Tahmininiz: ");
                tahmin = Console.ReadLine();
                try
                {
                    sayiTahmin = Convert.ToInt32(tahmin);
                }
                catch
                {
                    Console.WriteLine("Hatalı bir giriş yaptınız");
                    continue;
                }
                if (sayiTahmin < 10 && sayiTahmin >= 1)

                {
                    if (sayiTahmin != tuttuguSayi)
                    {
                        sayac = sayac + 1;
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Bilgisayarın tuttuğu " + tuttuguSayi + " sayısını " + sayac + ". tahminde buldunuz.");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Lüttfen 1-10 arasında bir sayı giriniz");
                    continue;
                }

            }
            Console.ReadLine();
        }
    }
}

