using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject15._2
{
    class Program
    {
        static void Main(string[] args)
        {//vizenin %40'ı finalin %60

            uint vize;
            uint final;
            double ort;
            while (true)
            {
                try
                {
                    Console.WriteLine("Lütfen vize notunu giriniz.");
                    string a = Console.ReadLine();
                    if (a == "q" || a == "Q")
                    {
                        return;
                    }

                    vize = Convert.ToUInt32(a);
                    if (vize > 100)
                    {
                        Console.WriteLine("Hatalı bir tuşlama yaptınız.");
                        continue;

                    }
                    Console.WriteLine("Lütfen final giriniz");
                    final = Convert.ToUInt32(Console.ReadLine());
                    if (final > 100)
                    {
                        Console.WriteLine("Hatalı bir tuşlama yaptınız.");
                        continue;

                    }


                    ort = (double)(vize*0.4+final*0.6);
                    if (ort <= 50)
                    {
                        Console.WriteLine($"Sınıfı Geçemediniz.Ortalamanız {ort}");
                        Console.ReadLine();

                    }
                    else
                    {
                        Console.WriteLine($"Sınıfı geçtiniz.Ortalamanız {ort}");
                        Console.ReadLine();

                    }

                }
                catch (FormatException fexp)
                {
                    Console.WriteLine("Hatalı bir tuşlama yaptınız.", fexp.Message);
                }
                catch
                {

                    Console.WriteLine("Hatalı bir tuşlama yaptınız.");
                }


            }
        }
    }
}
