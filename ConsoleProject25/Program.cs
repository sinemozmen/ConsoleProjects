using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject25
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayac = 1;
            int toplam = 0;
            string okunan = "";
            int girilen = 0;

            while (true)
            {
                try
                {
                    Console.WriteLine("Kaç adet sayı toplayacaksınız?");
                    girilen = Convert.ToInt32(Console.ReadLine());

                }
                catch
                {
                    Console.WriteLine("Hatalı giriş");
                    continue;
                }

                while (true)
                {
                    try
                    {
                        Console.Write(sayac + ". sayıyı giriniz :");
                        int sayi = Convert.ToInt32(Console.ReadLine());
                        toplam = toplam + sayi;
                        if (girilen != sayac)
                        {
                            okunan = okunan + Convert.ToString(sayi) + "+";
                        }
                        else
                        {
                            okunan = okunan + Convert.ToString(sayi);
                        }
                        sayac = sayac + 1;
                    }
                    catch
                    {
                        Console.WriteLine("Hatalı giriş");
                        continue;
                    }
                    if (sayac > girilen)
                        break;
                }
                Console.WriteLine("Sayıların toplamu = " + okunan + "= " + toplam);
                Console.ReadLine();
                return;
            }
        }

    }
}

