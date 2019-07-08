using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject18
{
    class Program
    {
        static void Main(string[] args)
        {// klavyeden 2 ürünün fiyatı ayrı ayrı girildiğinde 2 ürünün toplam fiyatı 200 tlden fazla ise 
         // 2.üründen %25 indirim yaparak, 2 ürün için toplam ödenecek tutarı gösteren uygulamayı yapınız.
           
            double urunFiyat1,urunFiyat2,toplamFiyat; 
            Console.WriteLine("1.ürünün fiyatını giriniz.");
            urunFiyat1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.ürünün fiyatını giriniz.");
            urunFiyat2 = Convert.ToInt32(Console.ReadLine());

            toplamFiyat = urunFiyat1 + urunFiyat2;
            if (toplamFiyat >= 200) 
            {
                toplamFiyat = urunFiyat1 + urunFiyat2 * 0.75;
                Console.WriteLine($"Ürünün fiyatı: {toplamFiyat}");
                Console.WriteLine("Toplam indirim: " + urunFiyat2*0.25 );
                Console.ReadLine(); 
            }else
            {
                Console.WriteLine($"Ürünün fiyatı: {toplamFiyat}");
                Console.WriteLine("Toplam indirim: " + 0);
                Console.ReadLine();

            }


        }
    }
}
