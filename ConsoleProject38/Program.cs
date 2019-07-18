using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject38
{
    class Program
    {    //Kullanıcı alacağı para üstünü girsin 
         //Para üstü veren makinede sadece 2 , 5 ve 10'luk banknotlar bulunmaktadır.
         //Kullanıcıya en az adet banknot ile para üstü veren uygulamayı yazınız.
         //Eğer kullanıcı para üstü olarak direkt 1 veya 3 yazarsa sistem uyarı mesajı versin .
        static void Main(string[] args)
        {
            int onlukAdedi;
            int beslikAdedi;
            int ikilikAdedi;
            int kalan;
            int paraUstu;
            int ekIkilikAdedi;

            Console.WriteLine("Lütfen para üstü giriniz.");
            paraUstu = Convert.ToInt32(Console.ReadLine());

            onlukAdedi = paraUstu / 10;
            paraUstu = paraUstu % 10;

            beslikAdedi = paraUstu / 5;
            paraUstu = paraUstu % 5;

            ikilikAdedi = paraUstu / 2;
            paraUstu = paraUstu % 2;

            kalan = paraUstu;

            if (kalan > 0)            
            {
                if (beslikAdedi > 0)
                {
                    beslikAdedi--;
                    ekIkilikAdedi = (5 + kalan) / 2;
                    ikilikAdedi = ikilikAdedi + ekIkilikAdedi;
                    kalan = 0;
                }
                else
                {
                    if (onlukAdedi > 0)
                    {
                        onlukAdedi--;
                        beslikAdedi++;
                        ekIkilikAdedi = (5 + kalan) / 2;
                        ikilikAdedi = ikilikAdedi + ekIkilikAdedi;
                        kalan = 0;
                    }
                    else
                    {
                        Console.WriteLine("Lütfen 1 veya 3 dışında bir para üstü giriniz.");
                        return;
                    }
                }
            }
            Console.WriteLine("Onluk adet sayisi = " + onlukAdedi);
            Console.WriteLine("Beslik adet sayisi = " + beslikAdedi);
            Console.WriteLine("İkilik adet sayisi = " + ikilikAdedi);
            Console.WriteLine("Kalan=" + kalan);
            Console.ReadLine();
        }
    }
}
