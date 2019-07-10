using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject26
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                int girilen;
                try
                {
                    Console.WriteLine("Hangi Fibonacci sayısını görmek istersiniz ? ");
                    girilen = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Hatalı giriş yaptınız.");
                        continue;
                }
                int sayi1 = 1;
                int sayi2 = 1;          //0 1 1 2 3 5 
                int sayac = 2;
                int toplam = 0;
                string okunan = "";
                okunan = Convert.ToString(sayi1) + "," + Convert.ToString(sayi2);
                //Console.Write(sayi1+""+sayi2+"");
                while (girilen > sayac)
                {
                    toplam = sayi1 + sayi2;
                    okunan = okunan + "," + Convert.ToString(toplam);
                    //Console.Write(toplam+"");
                    sayi1 = sayi2;
                    sayi2 = toplam;
                    sayac++;
                }
                Console.WriteLine(girilen + " . fibonacci sayısı =" + okunan);
                Console.ReadLine();
            }
        }
    }
}
