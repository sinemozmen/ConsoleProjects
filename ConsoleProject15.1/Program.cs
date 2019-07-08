using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject15._1
{
    class Program
    {
        static void Main(string[] args)
        {// girilen 2 notun ortalamasını bulan console çalışması


            uint not1;
            uint not2;
            double ort;
            while (true) 
            {
                try
                {
                    Console.WriteLine("Lütfen 1.Notu giriniz.");
                    string a = Console.ReadLine();
                    if (a == "q" || a == "Q")
                    {
                        return;
                    }

                    not1 = Convert.ToUInt32(a);
                    if (not1>100)
                    {
                        Console.WriteLine("Hatalı bir tuşlama yaptınız.");
                        continue;

                    }
                    Console.WriteLine("Lütfen 2.Notu giriniz");
                    not2 = Convert.ToUInt32(Console.ReadLine());
                    if (not2 > 100)
                    {
                        Console.WriteLine("Hatalı bir tuşlama yaptınız.");
                        continue;

                    }


                    ort = (double)(not1 + not2) / 2;
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





         